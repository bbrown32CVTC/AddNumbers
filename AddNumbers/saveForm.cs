using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

/*
 * Created by: Bruce Brown 
 * Date Created: 7/25/2024
 * 
 * 7/25/2024 - Created this form to give the user the option of saving in MyDocuments or 
 * doing a "Save As" to name the file theirself in the location they desire. 
 */


namespace AddNumbers
{
    public partial class saveForm : Form
    {
        private double runningTotal = 0, avgWeight = 0, stdDeviation, minWeight, maxWeight, bundleLimit, remainingLimit;
        private int shimCount = 0;
        private string[] lines;

        public saveForm(double runningTotal, int shimCount, double avgWeight, double stdDeviation,
            double minWeight, double maxWeight, double bundleLimit, double remainingLimit)

        {
            InitializeComponent();
            this.runningTotal = runningTotal;
            this.shimCount = shimCount;
            this.avgWeight = avgWeight;
            this.stdDeviation = stdDeviation;
            this.minWeight = minWeight;
            this.maxWeight = maxWeight;
            this.bundleLimit = bundleLimit;
            this.remainingLimit = remainingLimit;

            // Create a string array with the lines of text 
            this.lines = new string[] {DateTime.Now.ToString("MM/dd/yyyy h:mm tt"), $"Total Weight: {this.runningTotal} lbs",
                $"Total Shims: {this.shimCount}",  $"\nAverage Weight: {this.avgWeight}", $"\nStandard Deviation: {this.stdDeviation}",
                $"\nMinimum Weight : {this.minWeight}", $"\nMaximum Weight : {this.maxWeight}", $"\nBundle Limit: {this.bundleLimit} lbs",
                $"\nLimit Remaining: {this.remainingLimit} lbs\n" };
        }

        private void writeBtn_Click(object sender, EventArgs e)
        {
            // Set a variable to the Documents path. 
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Set today's date and file name
            String today = DateTime.Now.ToString("MM-dd-yyyy");
            String fullPath = docPath + $"\\ShimAccumulator_{today}.txt";

            // Append to current file if it exists, otherwise create the file
            if (File.Exists(fullPath))
            {
                // Append lines to the current file
                using (StreamWriter outputFile = File.AppendText(fullPath)) {

                    foreach (string line in this.lines)
                        outputFile.WriteLine(line);
                }

            }
            else
            {
                // Write the string array to a new file named "ShimAccumulator_(Date).txt". 
                using (StreamWriter outputFile = new
                StreamWriter(Path.Combine(docPath, $"ShimAccumulator_{today}.txt")))
                {
                    foreach (string line in this.lines)
                        outputFile.WriteLine(line);
                }
            }

            this.DialogResult = DialogResult.OK;
        }

        private void saveAsBtn_Click(object sender, EventArgs e)
        {
            // Create Stream and Save File Dialog
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Save file path
                String filePath = saveFileDialog1.FileName;

                // Append to current file if it exists, otherwise create the file
                if (File.Exists(filePath))
                {
                    // Append lines to the current file
                    using (StreamWriter outputFile = File.AppendText(filePath))
                    {

                        foreach (string line in this.lines)
                            outputFile.WriteLine(line);
                    }

                }
                else
                {
                    // Write the string array to a new file named "ShimAccumulator_(Date).txt". 
                    using (StreamWriter outputFile = new StreamWriter(filePath))
                    {
                        foreach (string line in this.lines)
                            outputFile.WriteLine(line);
                    }
                }

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                // Threw an error during save or was cancelled
                this.DialogResult = DialogResult.Cancel;
            }
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
