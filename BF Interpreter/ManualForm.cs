// Used namespaces
using System;
using System.Windows.Forms;

/// <summary>
/// BF interpreter namespace
/// </summary>
namespace BF_Interpreter {
    /// <summary>
    /// Manual form for the BF esoteric programming language
    /// </summary>
    public partial class ManualForm : Form {
        /// <summary>
        /// Constructor for the manual form
        /// </summary>
        public ManualForm () {
            InitializeComponent ();
        }

        /// <summary>
        /// Method for when the ok button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click ( object sender, EventArgs e ) {
            // Close the manual form
            this.Close ();
        }
    }
}
