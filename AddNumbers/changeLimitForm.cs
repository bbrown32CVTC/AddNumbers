using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AddNumbers
{
    public partial class changeLimitForm : Form
    {
        public double bundleAmount = 5.0, inputValue;

        public changeLimitForm()
        {
            InitializeComponent();
            this.changeAmountTB.Text = Convert.ToString(bundleAmount);
            this.errorLabel.Hide();

            // Set the cursor in the input textbox and highlight amount
            this.changeAmountTB.Select();
            this.changeAmountTB.SelectionLength = this.changeAmountTB.Text.Length;
        }

        private void ApproveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Hide error message label if it is displayed
                if (this.errorLabel.Visible)
                {
                    this.errorLabel.Hide();
                }

                // Try to convert from string to double value
                this.inputValue = Convert.ToDouble(this.changeAmountTB.Text);

                // Display error and reset input textbox if input value is less than or equal to 0
                if (this.inputValue <= 0)
                {
                    this.errorLabel.Text = "Error: Input must be greater than 0. Please try again.";
                    this.errorLabel.Show();
                    this.changeAmountTB.Text = Convert.ToString(bundleAmount);

                    // Set the cursor in the input textbox
                    this.changeAmountTB.Select();
                    this.changeAmountTB.SelectionLength = this.changeAmountTB.Text.Length;
                }
                else
                {
                    this.bundleAmount = this.inputValue;
                    this.DialogResult = DialogResult.OK;
                }

            }
            catch
            {
                // Catch the error received from bad input data and display it on the form
                this.errorLabel.Text = "Error: Input requires a number. Please try again.";
                this.errorLabel.Show();

                // Reset the input text
                this.changeAmountTB.Text = Convert.ToString(bundleAmount);

                // Set the cursor in the input textbox and highlight amount
                this.changeAmountTB.Select();
                this.changeAmountTB.SelectionLength = this.changeAmountTB.Text.Length;
            }

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }

}
