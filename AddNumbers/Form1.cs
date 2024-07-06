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
 */

namespace AddNumbers
{
    /// <summary>
    /// Simple Win Form App to demonstrate a simple application
    /// that can keep a running total and display the output.
    /// Will catch errors when the input is not a number
    /// and output the error message.The user can utilize
    /// the running total calculation option after the first
    /// calculation. Inputting 0 will output the running total
    /// and refresh the application to its original state.
    /// Hitting the clear/reset button will also refresh
    /// the application to its original state.
    /// </summary>


    public partial class Form1 : Form
    {
        // Initialize variables
        private double inputValue, answer, runningTotal = 0;

        public Form1()
        {
            InitializeComponent();

            // Hide the reset button until initial input value added
            this.resetBtn.Hide();

            // Set the cursor in the first textbox
            this.inputValueTB.Select();

            // Display the beginning total sum in the textbox
            this.totalSumTB.Text = Convert.ToString(this.runningTotal);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Try to convert from string to double value
                this.inputValue = Convert.ToDouble(this.inputValueTB.Text);

                // Calculate the answer, add to running total, and display the result
                this.answer = this.inputValue + this.runningTotal;
                this.runningTotal = this.answer;
                this.totalSumTB.Text = Convert.ToString(this.answer);

                // Unhide the reset button
                this.resetBtn.Show();

                // Reset the input textbox
                this.inputValueTB.Text = "";

                // Set the cursor in the input textbox
                this.inputValueTB.Select();

                //Output the running total and reset the accumulator if input value is 0
                if(this.inputValue == 0)
                {
                    MessageBox.Show($" Total = {this.runningTotal}", "Running Total");
                    button2_Click(sender, e);
                }

            }
            catch
            {
                // Catch the error received from bad input data and display it as an output
                MessageBox.Show("Error on input. Input requires a number.", "WARNING");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Stops the running total and hides reset button
            this.resetBtn.Hide();

            // Resets the input and total sum textboxes
            this.inputValueTB.Text = "";
            this.totalSumTB.Text = "";

            // Reset the total sum
            this.runningTotal = 0;

            // Display the new total sum in the textbox
            this.totalSumTB.Text = Convert.ToString(this.runningTotal);

            // Set the cursor in the input textbox
            this.inputValueTB.Select();
        }
    }
}
