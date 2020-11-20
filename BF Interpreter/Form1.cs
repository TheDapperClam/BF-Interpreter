/* Created by James "TheDapperClam"
 * https://www.dappercoding.com
 * 8/8/2018
 * This is a interpreter used for writing and reading the BF esoteric programming language
*/

// Used namespaces
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

/// <summary>
/// Namespace for the BF interpreter
/// </summary>
namespace BF_Interpreter {
    /// <summary>
    /// Form used for writing and interpreting the BF language
    /// </summary>
    public partial class InterpreterForm : Form {
        // Stores the animation speed for the animation timer
        public const int ANIMATION_SPEED_Integer = 10;

        // Points to the current byte
        private byte bytePointer = 0;
        // Stores the bytes for the interpreter
        private byte[] bytes = new byte[ 27 ];
        // Stack for storing the index of bracket loops
        private Stack<int> loopEnterStack = new Stack<int> ();
        // Store the current character index for the interpreter
        private int charIndex = -1;
        // Stores the characters that the interpreter should read instead of skipping over
        private char[] validCharacters = new char[] { '>', '<', '+', '-', '.', ',', '[', ']' };
        // Stores whether or not the interpreter is currenlty paused
        bool interpreterPaused = false;
        // Stores the width of the run button
        private int runButtonStartingWidth = 0;
        private int runButtonTargetWidth = 0;
        // Stores whether or not the current code is dirty
        private bool dirtyCode = false;
        // Stores the path for the currenlty opened file
        private string currentFilePath = null;

        /// <summary>
        /// Constructor for the form
        /// </summary>
        public InterpreterForm () {
            InitializeComponent ();
        }

        /// <summary>
        /// Method for when the run button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void runButton_Click ( object sender, EventArgs e ) {
            // Reset the character index
            charIndex = -1;
            // Clear the output
            outputTextBox.Clear ();
            // Reset the byte pointer
            bytePointer = 0;
            // Reset every byte
            for ( int i = 0; i < bytes.Length; i++ )
                bytes[ i ] = 0;
            // Update the byte text boxes
            UpdateByteTextBoxes ();

            // Toggle the interpreter
            SetInterpreter ( !interpreterTimer.Enabled );
        }

        /// <summary>
        /// Method for updating the byte text boxes to their respective byte
        /// </summary>
        private void UpdateByteTextBoxes () {
            // Loop through all bytes
            for ( int i = 0; i < bytes.Length; i++ ) {
                Control c;

                // Set and make sure that there is a text box associated with the current byte
                if ( ( c = this.Controls[ "byteTextBox" + i ] ) == null )
                    continue;

                // Update the current byte text box value
                c.Text = bytes[ i ].ToString ();

                if ( i == bytePointer )
                    // Set the back color of the currently select byte text box to red
                    c.BackColor = Color.Red;
                else
                    // Set the back color of the currently select byte text box to black
                    c.BackColor = Color.Black;
            }
        }

        private int GetNextValidCharIndex ( int start ) {
            if ( start < 0 || start >= inputRichTextBox.Text.Length )
                return -1;

            for ( int i = start; i < inputRichTextBox.Text.Length; i++ ) {
                if ( !validCharacters.Contains ( inputRichTextBox.Text[ i ] ) )
                    continue;

                return i;
            }

            return -1;
        }

        private void InterpreterTick () {
            // Move on to the next character
            charIndex = GetNextValidCharIndex ( charIndex + 1 );
            HighlightInputChar ( charIndex, Color.White, Color.Black );

            // Disable timer if character index is out of bounds
            if ( charIndex < 0 || charIndex >= inputRichTextBox.Text.Length ) {
                SetInterpreter ( false );
                return;
            }

            // Loop through every char in the input rich text box
            switch ( inputRichTextBox.Text[ charIndex ] ) {
                case '>':
                    // Increment the byte pointer
                    bytePointer++;
                    break;

                case '<':
                    // Decrement the byte pointer
                    bytePointer--;
                    break;

                case '+':
                    // Increment the current byte value
                    bytes[ bytePointer ]++;
                    break;

                case '-':
                    // Decrement the current byte value
                    bytes[ bytePointer ]--;
                    break;

                case '.':
                    // Output the current byte's character
                    outputTextBox.Text += (char) bytes[ bytePointer ];
                    break;

                case ',':
                    // Disable the timer for now
                    interpreterTimer.Enabled = false;

                    // Create and show an input form
                    InputForm iForm = new InputForm ();
                    iForm.ShowDialog ();

                    // Set the current byte to the user's input if the input is valid
                    if ( iForm.ValidInput )
                        bytes[ bytePointer ] = iForm.InputValue;

                    // Enable the timer
                    interpreterTimer.Enabled = true;
                    break;

                case '[':
                    // Check if the current byte is equal to 0
                    if ( bytes[ bytePointer ] == 0 ) {
                        // Integer used for storing the ammount of extra opening brackets found
                        int extraBrackets = 0;

                        // Loop through the remaining characters in the input rich text box
                        for ( int j = charIndex; j < inputRichTextBox.Text.Length; j++ ) {
                            // Add an extra bracket if an opening bracket is found
                            if ( inputRichTextBox.Text[ j ] == '[' )
                                extraBrackets++;

                            // Continue loop if the current character isn't a closing bracket
                            if ( inputRichTextBox.Text[ j ] != ']' )
                                continue;

                            // Remove one extra opening bracket
                            extraBrackets--;
                            // Continue loop if there are any extra opening brackets
                            if ( extraBrackets > 0 )
                                continue;

                            // Set the character index to the opening bracket's associated closing bracket
                            charIndex = j;
                            break;
                        }
                        break;
                    }

                    // Add the opening bracket index to the loop stack
                    loopEnterStack.Push ( charIndex );
                    break;

                case ']':
                    // Make sure the loop stack isn't null
                    if ( loopEnterStack == null )
                        break;

                    // Make sure the loop stack contains an element
                    if ( loopEnterStack.Count <= 0 )
                        break;

                    // Get the most recent index in the loop stack
                    int newIndex = loopEnterStack.Pop () - 1;

                    if ( bytes[ bytePointer ] == 0 )
                        break;

                    // Set the pointer to the most recent loop index
                    charIndex = newIndex;
                    break;
            }

            // Check if the pointer is currently out of bounds
            if ( bytePointer < 0 || bytePointer >= bytes.Length ) {
                // Disable the interpreter
                SetInterpreter ( false );
                // Tell the user that the pointer is out of bounds
                MessageBox.Show ( "The pointer is out of bounds", "Bounds Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }

            // Update the byte text boxes
            UpdateByteTextBoxes ();
        }

        private void HighlightInputChar ( int index, Color backgroundColor, Color characterColor ) {
            if ( index < 0 || index >= inputRichTextBox.Text.Length )
                return;

            inputRichTextBox.SelectionStart = 0;
            inputRichTextBox.SelectionLength = inputRichTextBox.Text.Length;
            inputRichTextBox.SelectionBackColor = Color.Black;
            inputRichTextBox.SelectionColor = Color.White;
            
            inputRichTextBox.SelectionStart = index;
            inputRichTextBox.SelectionLength = 1;
            inputRichTextBox.SelectionBackColor = backgroundColor;
            inputRichTextBox.SelectionColor = characterColor;
        }

        /// <summary>
        /// Method for when the interpreter timer ticks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void interpreterTimer_Tick ( object sender, EventArgs e ) {
            InterpreterTick ();
        }

        /// <summary>
        /// Method for when the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InterpreterForm_Load ( object sender, EventArgs e ) {
            // Set the starting width of the run button
            runButtonStartingWidth = this.Width - 16;
            // Set the targeted width of the run button
            runButtonTargetWidth = runButtonStartingWidth;
        }

        /// <summary>
        /// Method used for setting the run state of the interpreter
        /// </summary>
        /// <param name="active"></param>
        private void SetInterpreter ( bool active ) {
            HighlightInputChar ( 0, Color.Black, Color.White );

            // Return if there is no code inputted
            if ( GetNextValidCharIndex ( 0 ) < 0 )
                return;

            // Set the interpreter timers state
            interpreterTimer.Enabled = active && !interpreterPaused ? true : false;

            if ( interpreterTimer.Enabled )
                InterpreterTick ();

            // Set the input rich text box to read only depending on the state of the interpreter
            inputRichTextBox.ReadOnly = interpreterTimer.Enabled;
            interpretationSpeedTextBox.ReadOnly = interpreterTimer.Enabled;
            // Un-pause the interpreter
            interpreterPaused = false;

            // Check if the interpreter is active
            if ( interpreterTimer.Enabled ) {
                // Interpreter is active
                // Change the text on the run and pause buttons, as wheel as their background colors
                runButton.Text = "Stop";
                pauseButton.Text = "Pause";
                runButton.BackColor = Color.FromArgb ( 255, 192, 192 );
                pauseButton.BackColor = Color.FromArgb ( 128, 255, 255 );
                // Set the targeted width of the run button so that it animated slides to its on position
                runButtonTargetWidth = runButtonStartingWidth - pauseButton.Width + 6;
                
            } else {
                // Interpreter is not active
                // Change the text on the run and pause buttons, as wheel as their background colors
                runButton.Text = "Run";
                pauseButton.Text = "Pause";
                runButton.BackColor = Color.FromArgb ( 192, 255, 192 );
                pauseButton.BackColor = Color.FromArgb ( 128, 255, 255 );
                // Set the targeted width of the run button so that it animated slides to its off position
                runButtonTargetWidth = runButtonStartingWidth;
            }

            // Enable the animation timer
            animationTimer.Enabled = true;
        }

        /// <summary>
        /// Method for when the pause button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pauseButton_Click ( object sender, EventArgs e ) {
            // Toggle the pause state of the interpreter
            interpreterTimer.Enabled = !interpreterTimer.Enabled;
            interpreterPaused = !interpreterTimer.Enabled;

            // Change the text on the pause button depending on whether or not the interpreter is currently paused
            if ( interpreterPaused ) {
                // The interpreter is paused
                // Change the pause button text and background color
                pauseButton.Text = "Resume";
                pauseButton.BackColor = Color.FromArgb ( 192, 192, 255 );
            } else {
                // The interpreter is running
                // Change the pause button text and background color
                pauseButton.Text = "Pause";
                pauseButton.BackColor = Color.FromArgb ( 128, 255, 255 );
            }
        }

        /// <summary>
        /// Method for when the animation timer ticks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void animationTimer_Tick ( object sender, EventArgs e ) {
            // Disable animation if the run button has reached its targeted width
            if ( runButton.Width > runButtonTargetWidth - ANIMATION_SPEED_Integer && runButton.Width < runButtonTargetWidth + ANIMATION_SPEED_Integer )
                animationTimer.Enabled = false;

            // Re-size the run button
            runButton.Width += runButton.Width > runButtonTargetWidth ? -ANIMATION_SPEED_Integer : ANIMATION_SPEED_Integer;
            // Re-position the pause button
            pauseButton.Location = new Point ( runButton.Location.X + runButton.Width, pauseButton.Location.Y );
        }

        /// <summary>
        /// Method for when the form is resized
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InterpreterForm_Resize ( object sender, EventArgs e ) {
            // Change the starting with of the run button
            runButtonStartingWidth = this.Width - 16;
        }

        /// <summary>
        /// Method for when the exit button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click ( object sender, EventArgs e ) {
            // Close the form
            this.Close ();
        }

        /// <summary>
        /// Method for when the save file button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click ( object sender, EventArgs e ) {
            // Save the current file
            SaveFile ( currentFilePath );
        }

        /// <summary>
        /// Method for when the saved file as button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsToolStripMenuItem_Click ( object sender, EventArgs e ) {
            // Save the current file as
            SaveFile ();
        }

        /// <summary>
        /// Method for when the open file button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click ( object sender, EventArgs e ) {
            // Open a file
            OpenFile ();
        }

        /// <summary>
        /// Method for when the new file button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click ( object sender, EventArgs e ) {
            // Check if the current code is dirty
            if ( dirtyCode ) {
                // Display a dialog box asking the user if they want to save their changes
                switch ( MessageBox.Show ( "You currently have un-saved changes. Would you like to save?", "Un-saved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning ) ) {
                    case DialogResult.Yes:
                        if ( !SaveFile ( currentFilePath ) )
                            // Dont start a new project if the user cancels the save file dialog
                            return;

                        break;

                    case DialogResult.Cancel:
                        // Dont start a new project
                        return;
                }
            }

            // Clear the input rich text box
            inputRichTextBox.Clear ();
            // Clear the current file path
            currentFilePath = null;
            // Mark code as not dirty
            dirtyCode = false;
        }

        /// <summary>
        /// Method for when the input rich text box text changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inputRichTextBox_TextChanged ( object sender, EventArgs e ) {
            // The code in the input rich text box has changed, so it is now dirty
            dirtyCode = true;
        }

        /// <summary>
        /// Method used for opening a saved BF file
        /// </summary>
        private void OpenFile () {
            // Check if the current code is dirty
            if ( dirtyCode ) {
                // Display a dialog box asking the user if they want to save their changes
                switch ( MessageBox.Show ( "You currently have un-saved changes. Would you like to save?", "Un-saved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning ) ) {
                    case DialogResult.Yes:
                        // Cancel the open file dialog if the user cancels the save file dialog
                        if ( !SaveFile ( currentFilePath ) )
                            return;

                        break;

                    case DialogResult.Cancel:
                        // Cancel the open file dialog
                        return;
                }
            }

            // Create an open file dialog for opening a saved file
            OpenFileDialog openDialog = new OpenFileDialog ();
            openDialog.Filter = "James BF files (*.jbf)|*jbf";
            openDialog.FilterIndex = 0;
            openDialog.RestoreDirectory = true;

            // Return if the user cancels the open file dialog
            if ( openDialog.ShowDialog () != DialogResult.OK )
                return;

            // Set the current file path to the path provided by the user
            currentFilePath = openDialog.FileName;
            // Create a stream reader for reading the opened file
            StreamReader sReader = new StreamReader ( currentFilePath );

            // Set the input rich text box text to the file opened
            inputRichTextBox.Text = sReader.ReadToEnd ();
            // Close the stream reader
            sReader.Close ();
            // Mark code as not dirty
            dirtyCode = false;
        }

        /// <summary>
        /// Method used for saving the user's current code
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private bool SaveFile ( string path = null ) {
            // Check if there is a provided path
            if ( ( currentFilePath = path ) == null) {
                // Show a save file dialog window
                SaveFileDialog saveDialog = new SaveFileDialog ();
                saveDialog.Filter = "James BF files (*.jbf)|*jbf";
                saveDialog.FilterIndex = 0;
                saveDialog.RestoreDirectory = true;

                // Cancel save if the user cancels the save file dialog
                if ( saveDialog.ShowDialog () != DialogResult.OK )
                    return false;

                // Set the current file path to the path provided by the user
                currentFilePath = saveDialog.FileName;
            }

            // Create a stream writer for saving the user's code
            StreamWriter sWriter = new StreamWriter ( currentFilePath );

            // Loop through the lines of code and save them to a file
            foreach ( string s in inputRichTextBox.Lines )
                sWriter.WriteLine ( s );

            // Close the stream writer
            sWriter.Close ();
            // Mark code as not dirty
            dirtyCode = false;

            return true;
        }

        /// <summary>
        /// Method for when the form is about to close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InterpreterForm_FormClosing ( object sender, FormClosingEventArgs e ) {
            // Check if current code is dirty
            if ( dirtyCode ) {
                // Display a dialog box asking the user if they want to save their changes
                switch ( MessageBox.Show ( "You currently have un-saved changes. Would you like to save?", "Un-saved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning ) ) {
                    case DialogResult.Yes:
                        // Cancel the form exit if the user cancels the file save
                        if ( !SaveFile ( currentFilePath ) )
                            e.Cancel = true;
                        break;

                    case DialogResult.Cancel:
                        // Cancel the form exit
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void aboutToolStripMenuItem_Click ( object sender, EventArgs e ) {
            // Show the about box for the interpreter
            AboutBox aboutBox = new AboutBox ();
            aboutBox.ShowDialog ();
        }

        private void manualToolStripMenuItem_Click ( object sender, EventArgs e ) {
            // Show the manual for the BF esoteric programming language
            ManualForm mForm = new ManualForm ();
            mForm.Show ();
        }

        private void interpretationSpeedTextBox_Leave ( object sender, EventArgs e ) {
            int newInterp = interpreterTimer.Interval;
            int.TryParse ( interpretationSpeedTextBox.Text, out newInterp );
            newInterp = Math.Max ( newInterp, 1 );
            interpreterTimer.Interval = newInterp;
            interpretationSpeedTextBox.Text = newInterp.ToString ();
        }

        private void inputRichTextBox_Enter ( object sender, EventArgs e ) {
            if ( !interpreterTimer.Enabled && !interpreterPaused )
                return;

            runButton.Focus ();
        }
    }
}
