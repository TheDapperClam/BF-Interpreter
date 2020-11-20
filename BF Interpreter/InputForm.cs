using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BF_Interpreter {
    public partial class InputForm : Form {
        // Stores the user's input
        public byte InputValue { get; private set; } = 0;
        // Used for determining if the user's input is valid
        public bool ValidInput { get; private set; } = false;

        public InputForm () {
            InitializeComponent ();
        }

        private void okButton_Click ( object sender, EventArgs e ) {
            // Close form if an input hasn't been entered
            if ( inputTextBox.Text.Length <= 0 ) {
                this.Close ();
                return;
            }

            // Get the user's current input and then close the form
            InputValue = (byte) inputTextBox.Text[0];
            ValidInput = true;
            this.Close ();
        }
    }
}
