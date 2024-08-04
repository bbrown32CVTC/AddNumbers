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
 * 
 * 7/25/2024 - Created the saveForm form to give the user the option of saving in MyDocuments or 
 * doing a "Save As" to name the file theirself in the location they desire. 
 * 
 * 8/2/2024 - Updated the Help and Save/Print menu logic. Added About, Bundle Limit Change, and
 * Quit menu items and logic. Created a form and added logic for changing the bundle limit to a
 * variable rate. Added a labels and logic for the bundle limit, remaining shim limit, average weight,
 * standard deviation of weights,minimum weight, and maximum weight. Updated the help and about menus.
 * Updated the save/print logic to include additional labels and amounts.
 */

namespace AddNumbers
{
    /// <summary>
    /// Win Form App that will keep a running total of shims and their collective weight.
    /// Will catch errors when the input is not a number or less than or equal to zero,
    /// as well as display the error message on the form.The user can utilize the running 
    /// total calculation option after the first calculation. Clicking the save/print menu 
    /// button will give two options for saving, output the running totals, and reset the 
    /// application to its original state. Clicking the clear/reset button will also reset 
    /// the application to its original state. Clicking the Undo Last button will subtract 
    /// the last input and shim count added Clicking the Help menu button will display the 
    /// application's cinstructions and details.
    /// </summary>


    public partial class shimAccumulator : Form
    {
        // Initialize variables
        private double inputValue, answer, runningTotal = 0, lastWeight = 0, bundleLimit = 5, remainingLimit = 5;
        private double avgWeight = 0, stdDeviation = 0, minWeight = 0, maxWeight = 0;
        private int shimCount = 0;
        private Stack<double> inputs = new Stack<double>();

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

            // Display the beginning totals
            this.totalSumLabel.Text = $"Total Weight: {Convert.ToString(this.runningTotal)} lbs";
            this.totalShimLabel.Text = $"Total Shims: {Convert.ToString(this.shimCount)}";
            this.bundleLimitLabel.Text = $"Bundle Limit: {this.bundleLimit} lbs";
            this.limitRemaining.Text = $"Limit Remaining: {this.remainingLimit} lbs";
            this.avgWeightAmount.Text = this.avgWeight.ToString();
            this.stdDeviationAmount.Text = this.stdDeviation.ToString();
            this.minWeightAmount.Text = this.minWeight.ToString();
            this.maxWeightAmount.Text = this.maxWeight.ToString();
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
                    this.totalSumLabel.Text = $"Total Weight: {Convert.ToString(this.answer)} lbs";
                    this.totalShimLabel.Text = $"Total Shims: {Convert.ToString(this.shimCount)}";

                    // Update bundle remainder amount
                    updateBundleRemainder(this.inputValue);

                    // Add input to the stack
                    this.inputs.Push(this.inputValue);

                    //Calculate and display additional amounts
                    calcAdditionalAmounts(inputs);

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

        private void button2_Click(object sender, EventArgs e)  // Clear/Reset Button
        {
            // Stops the running totals and hides the reset and undo buttons
            this.resetBtn.Hide();
            this.undoBtn.Hide();

            // Resets the input and totals before displaying them
            this.inputValueTB.Text = "";
            this.runningTotal = 0;
            this.shimCount = 0;
            this.bundleLimit = 5;
            this.remainingLimit = this.bundleLimit;
            this.avgWeight = 0;
            this.stdDeviation = 0;
            this.minWeight = 0;
            this.maxWeight = 0;
            this.inputs = new Stack<double>();
            this.totalSumLabel.Text = $"Total Weight: {Convert.ToString(this.runningTotal)} lbs";
            this.totalShimLabel.Text = $"Total Shims: {Convert.ToString(this.shimCount)}";
            this.bundleLimitLabel.Text = $"Bundle Limit: {this.bundleLimit} lbs";
            this.limitRemaining.Text = $"Limit Remaining: {this.remainingLimit} lbs";
            calcAdditionalAmounts(inputs);

            // Hide error message label if it is displayed
            if (this.errorLabel.Visible)
            {
                this.errorLabel.Hide();
            }

            // Set the cursor in the input textbox
            this.inputValueTB.Select();
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            // Remove the last shim from the running totals and display the new amounts
            this.runningTotal -= this.lastWeight;
            this.inputs.Pop();
            this.shimCount--;
            this.remainingLimit += this.lastWeight;
            this.totalSumLabel.Text = $"Total Weight: {Convert.ToString(this.runningTotal)} lbs";
            this.totalShimLabel.Text = $"Total Shims: {Convert.ToString(this.shimCount)}";
            this.limitRemaining.Text = $"Limit Remaining: {this.remainingLimit} lbs";
            calcAdditionalAmounts(this.inputs);
            updateBundleRemainder();

            // Hide the undo button until the next acceptable input
            this.undoBtn.Hide();
        }

        private void saveAndPrintMenuItem_Click(object sender, EventArgs e)
        {
            // Hide error message label if it is displayed
            if (this.errorLabel.Visible)
            {
                this.errorLabel.Hide();
            }

            // Display Save Options Form
            saveForm sf = new saveForm(this.runningTotal, this.shimCount, this.avgWeight, this.stdDeviation,
                this.minWeight, this.maxWeight, this.bundleLimit, this.remainingLimit);
            sf.ShowDialog();

            if (sf.DialogResult == DialogResult.OK)
            {

                // Print the totals
                printTotals();

                // Reset the form
                button2_Click(sender, e);
            }
            else
            {
                // Display there was an error during the save
                this.errorLabel.Text = "Error during save or save was cancelled";
                this.errorLabel.Show();

                // Print the totals
                printTotals();
            }

        }

        private void helpMenuItem_Click(object sender, EventArgs e)
        {
            // Display support contact information
            MessageBox.Show("ProSync CS LLC \n\n1212 Sugar Blvd \nEau Claire, WI 54703 \n\n715-555-5525", "Contact Support");
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            // Display the instructions and details for operating this application
            MessageBox.Show("Input the weight of the shim and press enter or click 'Add' button to add the " +
                "input to the total weight. \n\nThis application will automatically increment the amount " +
                "of shims by one each time you add a positive shim weight. It will also advise the average weight, " +
                "standard deviation, min/max weights, bundle limit in pounds, and the limit remaining. Adding a" +
                " weight less than or equal to zero, or a non-numerical character, will populate an error message." +
                " Clicking the save/print button will give save options, display the totals, and reset the form when" +
                " successfully saved. The Quit menu will stop and close this application.", "Shim Accumulator Instructions");
        }

        private void quitMenuItem_Click(object sender, EventArgs e)
        {
            // Display Quit Validation Form
            quitForm qf = new quitForm();
            qf.ShowDialog();

            if (qf.DialogResult == DialogResult.OK)
            {
                // Quit and close application
                this.Close();
            }

        }

        private void bundleLimitChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Change the bundle limit if amount inputted is valid
            changeLimitForm clf = new changeLimitForm();
            clf.ShowDialog();

            // Logic based on selection
            if (clf.DialogResult == DialogResult.OK)
            {
                this.bundleLimit = clf.bundleAmount;
                this.remainingLimit = this.bundleLimit;
                this.bundleLimitLabel.Text = $"Bundle Limit: {this.bundleLimit} lbs";
                updateBundleRemainder(this.runningTotal);
            }

        }

        private void printTotals()
        {
            MessageBox.Show($"Total Weight: {this.runningTotal} lbs\n"
                   + $"\nTotal Shims: {this.shimCount}\n"
                   + $"\nAverage Weight: {this.avgWeightAmount.Text}\n"
                   + $"\nStandard Deviation: {this.stdDeviationAmount.Text}\n"
                   + $"\nMinimum Weight : {this.minWeightAmount.Text}\n"
                   + $"\nMaximum Weight : {this.maxWeightAmount.Text}\n"
                   + $"\nBundle Limit: {this.bundleLimit} lbs\n"
                   + $"\nLimit Remaining: {this.remainingLimit} lbs", "Totals");
        }

        private void calcAdditionalAmounts(Stack<double> stack)
        {
            // Calculate and display the average, standard deviation, min weight, and max weight
            if (stack == null || stack.Count == 0)
            {
                this.avgWeightAmount.Text = "0";
                this.stdDeviationAmount.Text = "0";
                this.minWeightAmount.Text = "0";
                this.maxWeightAmount.Text = "0";
            }
            else if (stack.Count >= 1)
            {
                // Get and save min/max numbers
                this.minWeight = stack.Min();
                this.maxWeight = stack.Max();

                // Calculate standard deviation
                if (stack.Count > 1)
                {
                    this.avgWeight = stack.Average();
                    double sum = stack.Sum(d => (d - this.avgWeight) * (d - this.avgWeight));
                    this.stdDeviation = Math.Sqrt(sum / stack.Count);
                }
                    
                // Display amounts
                this.avgWeightAmount.Text = Convert.ToString(this.avgWeight);
                this.stdDeviationAmount.Text= Convert.ToString(this.stdDeviation);
                this.minWeightAmount.Text = Convert.ToString(this.minWeight);
                this.maxWeightAmount.Text= Convert.ToString(this.maxWeight);
            }

        }

        private void updateBundleRemainder(double input)
        {
            this.remainingLimit -= input;
            this.limitRemaining.Text = $"Limit Remaining: {this.remainingLimit} lbs";

            // Disclaimer that the user exceeded the bundle limit
            if (this.remainingLimit < 0)
            {
                this.errorLabel.Text = "ALERT: Bundle Limit Has Been Exceeded!";
                this.errorLabel.Show();
            }
            else
            {
                // Hide error message label if it is displayed
                if (this.errorLabel.Visible)
                {
                    this.errorLabel.Hide();
                }

            }

        }

        private void updateBundleRemainder()
        {
            this.limitRemaining.Text = $"Limit Remaining: {this.remainingLimit} lbs";

            // Disclaimer that the user exceeded the bundle limit
            if (this.remainingLimit < 0)
            {
                this.errorLabel.Text = "ALERT: Bundle Limit Has Been Exceeded!";
                this.errorLabel.Show();
            }
            else
            {
                // Hide error message label if it is displayed
                if (this.errorLabel.Visible)
                {
                    this.errorLabel.Hide();
                }

            }

        }

    }

}
