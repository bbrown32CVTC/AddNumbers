using System.Runtime.CompilerServices;

namespace AddNumbers
{
    /*
     * Sample Win Form App to demonstrate a simple application
     * that can add two numbers and display the output.
     * Will catch errors when the input is not a number
     * and output the error message. The client can utilize
     * the running total calculation option after the first
     * calculation. Hitting the restart button will refresh
     * the application to its original state.
     * 
     * Software Engineering unit 1, Bruce Brown, 6/26/2024
     */

    public partial class Form1 : Form
    {
        // Initialize variables
        private double value1, value2, value3, answer, runningTotal;

        public Form1()
        {
            InitializeComponent();

            // Hide the additional options and stop button
            this.addMoreGB.Hide();
            this.button2.Hide();

            // Set the cursor in the first textbox
            this.firstValueText.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.initialValuesGB.Visible)
                {
                    // Try to convert from string to double value
                    this.value1 = Convert.ToDouble(this.firstValueText.Text);
                    this.value2 = Convert.ToDouble(this.secondValueText.Text);

                    // Calculate the answer, add to running total, and display the result
                    this.answer = this.value1 + this.value2;
                    this.runningTotal = this.answer;
                    this.resultTextBox.Text = Convert.ToString(answer);

                    // Unhide the running total objects
                    this.addMoreGB.Show();
                    this.button2.Show();

                    // Hide the first and second value objects
                    this.initialValuesGB.Hide();

                    // Change the answer label to running total
                    this.label4.Text = "Total";

                    // Set the cursor in the textbox
                    this.addMoreTB.Select();

                }
                else
                {
                    // Try to convert from string to double value
                    this.value3 = Convert.ToDouble(this.addMoreTB.Text);

                    // Calculate the answer, add to running total, and display the result
                    this.answer = this.runningTotal + this.value3;
                    this.runningTotal = this.answer;
                    this.resultTextBox.Text = Convert.ToString(answer);

                    // Reset the input textbox with the cursor in the textbox
                    this.addMoreTB.Text = "";
                    this.addMoreTB.Select();
                }

            }
            catch
            {
                // Catch the error received from bad input data and display it as an output
                MessageBox.Show("Error on input", "WARNING");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Stops the running total and hides all running total objects
            this.addMoreGB.Hide();
            this.button2.Hide();

            // Resets the original text boxes
            this.firstValueText.Text = "";
            this.secondValueText.Text = "";
            this.label4.Text = "Answer";
            this.resultTextBox.Text = "";

            // Unhides the original text boxes and labels
            this.initialValuesGB.Show();

            // Set the cursor in the first textbox
            this.firstValueText.Select();
        }
    }
}
