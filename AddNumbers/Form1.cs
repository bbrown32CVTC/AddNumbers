using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

/*
 * Created by: Bruce Brown 
 * Date Created: 6/26/2024
 * 
 * 7/6/2024 - Updated app to only use one input, allow enter key to add input to sum, 
 * accept input value 0 as a flag to output running total, display the total sum of 0 
 * when app starts, and changed the Restart button text to "clear / reset". Enhanced the 
 * form design.
 * 
 * 7/13/2024 - Updated app to track and display amount of shims added. Added an undo button
 * and logic to undo the last shim weight and count added. Added a help menu button. Updated
 * and rearranged the user interface. Updated the error message logic to be displayed on 
 * the form instead of a message box.
 * 
 */

namespace AddNumbers
{
    /// <summary>
    /// Simple Win Form App to demonstrate a simple application that
    /// can keep a running total of shims and their collective weight.
    /// Will catch errors when the input is not a number
    /// and output the error message.The user can utilize
    /// the running total calculation option after the first
    /// calculation. Inputting 0 will output the running total
    /// and refresh the application to its original state.
    /// Hitting the clear/reset button will also refresh
    /// the application to its original state.
    /// </summary>


    public partial class shimAccumulator : Form
    {
        // Initialize variables
        private double inputValue, answer, runningTotal = 0, lastWeight = 0;
        private int shimCount = 0;

        public shimAccumulator()
        {
            InitializeComponent();

            // Hide the reset and undo buttons until initial input value added
            this.resetBtn.Hide();
            this.undoBtn.Hide();

            // Hide error message label until and error is received
            this.errorLabel.Hide();

            // Set the cursor in the first textbox
            this.inputValueTB.Select();

            // Display the beginning total weight and shims in the textbox
            this.totalSumLabel.Text = $"Total weight: {Convert.ToString(this.runningTotal)}";
            this.totalShimLabel.Text = $"Total Shims: {Convert.ToString(this.shimCount)}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Hide error message label if it is displayed
                if (this.errorLabel.Visible)
                {
                    this.errorLabel.Hide();
                }

                // Try to convert from string to double value
                this.inputValue = Convert.ToDouble(this.inputValueTB.Text);

                // Track last weight added in case undo button is hit
                this.lastWeight = this.inputValue;

                // Calculate the answer, add to total weight, add to total shims, and display the results
                this.answer = this.inputValue + this.runningTotal;
                this.runningTotal = this.answer;
                this.shimCount++;
                this.totalSumLabel.Text = $"Total weight: {Convert.ToString(this.answer)}";
                this.totalShimLabel.Text = $"Total Shims: {Convert.ToString(this.shimCount)}";

                // Unhide the reset and undo buttons
                this.resetBtn.Show();
                this.undoBtn.Show();

                // Reset the input textbox
                this.inputValueTB.Text = "";

                // Set the cursor in the input textbox
                this.inputValueTB.Select();

                //Output the running total and reset the accumulator if input value is 0
                if (this.inputValue == 0)
                {
                    MessageBox.Show($" Total Weight: {this.runningTotal} \nTotal Shims: {this.shimCount}", "Totals");
                    button2_Click(sender, e);
                }

            }
            catch
            {
                // Catch the error received from bad input data and display it on the form
                this.errorLabel.Text = "Error: Input requires a number. Please try again.";
                this.errorLabel.Show();

                // Reset the input text
                this.inputValueTB.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Stops the running totals and hides the reset and undo buttons
            this.resetBtn.Hide();
            this.undoBtn.Hide();

            // Resets the input and totals before displaying them
            this.inputValueTB.Text = "";
            this.runningTotal = 0;
            this.shimCount = 0;
            this.totalSumLabel.Text = $"Total weight: {Convert.ToString(this.runningTotal)}";
            this.totalShimLabel.Text = $"Total Shims: {Convert.ToString(this.shimCount)}";

            // Set the cursor in the input textbox
            this.inputValueTB.Select();
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            // Remove the last shim from the running totals and display the new amounts
            this.runningTotal -= this.lastWeight;
            this.shimCount--;
            this.totalSumLabel.Text = $"Total weight: {Convert.ToString(this.runningTotal)}";
            this.totalShimLabel.Text = $"Total Shims: {Convert.ToString(this.shimCount)}";

            // Hide the undo button until the next acceptable input
            this.undoBtn.Hide();
        }
    }
}
