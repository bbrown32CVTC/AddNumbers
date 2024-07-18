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
 * 7/18/2024 - Added logic to display an error when the input is less than or equal to 0.
 * Added a save/print menu button. Added logic to display the total weight and shim count
 * in a pop-up window and reset the form when the save/print button is clicked. Implemented
 * the Help menu button, which will display the instructions and details for this application.
 */

namespace AddNumbers
{
    /// <summary>
    /// Win Form App that will keep a running total of shims and their collective weight.
    /// Will catch errors when the input is not a number or less than or equal to zero,
    /// as well as display the error message on the form.The user can utilize the running 
    /// total calculation option after the first calculation. Clicking the save/print menu 
    /// button will output the running totals and reset the application to its original state. 
    /// Clicking the clear/reset button will also reset the application to its original state. 
    /// Clicking the Undo Last button will subtract the last input and shim count added Clicking 
    /// the Help menu button will display the application's instructions and details.
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
            this.totalSumLabel.Text = $"Total weight: {Convert.ToString(this.runningTotal)} lbs";
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

                // Display error and reset input textbox if input value is less than or equal to 0
                if (this.inputValue <= 0)
                {
                    this.errorLabel.Text = "Error: Input must be greater than 0. Please try again.";
                    this.errorLabel.Show();
                    this.inputValueTB.Text = "";
                }
                else
                {

                    // Track last weight added in case undo button is hit
                    this.lastWeight = this.inputValue;

                    // Calculate the answer, add to total weight, add to total shims, and display the results
                    this.answer = this.inputValue + this.runningTotal;
                    this.runningTotal = this.answer;
                    this.shimCount++;
                    this.totalSumLabel.Text = $"Total weight: {Convert.ToString(this.answer)} lbs";
                    this.totalShimLabel.Text = $"Total Shims: {Convert.ToString(this.shimCount)}";

                    // Unhide the reset and undo buttons
                    this.resetBtn.Show();
                    this.undoBtn.Show();

                    // Reset the input textbox
                    this.inputValueTB.Text = "";

                    // Set the cursor in the input textbox
                    this.inputValueTB.Select();
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
            this.totalSumLabel.Text = $"Total weight: {Convert.ToString(this.runningTotal)} lbs";
            this.totalShimLabel.Text = $"Total Shims: {Convert.ToString(this.shimCount)}";

            // Set the cursor in the input textbox
            this.inputValueTB.Select();
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            // Remove the last shim from the running totals and display the new amounts
            this.runningTotal -= this.lastWeight;
            this.shimCount--;
            this.totalSumLabel.Text = $"Total weight: {Convert.ToString(this.runningTotal)} lbs";
            this.totalShimLabel.Text = $"Total Shims: {Convert.ToString(this.shimCount)}";

            // Hide the undo button until the next acceptable input
            this.undoBtn.Hide();
        }

        private void saveAndPrintMenuItem_Click(object sender, EventArgs e)
        {
            // Display total weight and count of shims in pop-up window
            MessageBox.Show($"Total weight: {Convert.ToString(this.runningTotal)} lbs" +
                $"\n\nTotal Shims: {Convert.ToString(this.shimCount)}", "Saved!");

            // Reset the form
            button2_Click(sender, e);
        }

        private void helpMenuItem_Click(object sender, EventArgs e)
        {
            // Display the instructions and details for operating this application
            MessageBox.Show("Input the weight of the shim and press enter or click 'Add' button to add the " +
                "input to the total weight. \n\nThis application will automatically increment the amount " +
                "of shims by one each time you add a positive shim weight. Adding a weight less than " +
                "or equal to zero, or a non-numerical character, will populate an error message. Clicking " +
                "the save/print button will display the totals and reset the form.", "Instructions");
        }
    }
}
