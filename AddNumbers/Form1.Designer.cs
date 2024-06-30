namespace AddNumbers
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            firstValueLabel = new Label();
            secondValueLabel = new Label();
            firstValueText = new TextBox();
            secondValueText = new TextBox();
            button1 = new Button();
            resultTextBox = new TextBox();
            label4 = new Label();
            addMoreLabel = new Label();
            addMoreTB = new TextBox();
            button2 = new Button();
            initialValuesGB = new GroupBox();
            addMoreGB = new GroupBox();
            initialValuesGB.SuspendLayout();
            addMoreGB.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(45, 9);
            label1.Name = "label1";
            label1.Size = new Size(349, 29);
            label1.TabIndex = 0;
            label1.Text = "Simple App to Add Numbers";
            // 
            // firstValueLabel
            // 
            firstValueLabel.AutoSize = true;
            firstValueLabel.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            firstValueLabel.Location = new Point(6, 19);
            firstValueLabel.Name = "firstValueLabel";
            firstValueLabel.Size = new Size(111, 23);
            firstValueLabel.TabIndex = 1;
            firstValueLabel.Text = "First Value";
            // 
            // secondValueLabel
            // 
            secondValueLabel.AutoSize = true;
            secondValueLabel.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            secondValueLabel.Location = new Point(6, 73);
            secondValueLabel.Name = "secondValueLabel";
            secondValueLabel.Size = new Size(139, 23);
            secondValueLabel.TabIndex = 2;
            secondValueLabel.Text = "Second Value";
            // 
            // firstValueText
            // 
            firstValueText.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firstValueText.Location = new Point(163, 19);
            firstValueText.Name = "firstValueText";
            firstValueText.Size = new Size(215, 27);
            firstValueText.TabIndex = 3;
            // 
            // secondValueText
            // 
            secondValueText.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            secondValueText.Location = new Point(163, 73);
            secondValueText.Name = "secondValueText";
            secondValueText.Size = new Size(215, 27);
            secondValueText.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(45, 265);
            button1.Name = "button1";
            button1.Size = new Size(116, 67);
            button1.TabIndex = 5;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // resultTextBox
            // 
            resultTextBox.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            resultTextBox.Location = new Point(179, 288);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(116, 27);
            resultTextBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(198, 265);
            label4.Name = "label4";
            label4.Size = new Size(67, 18);
            label4.TabIndex = 7;
            label4.Text = "Answer";
            // 
            // addMoreLabel
            // 
            addMoreLabel.AutoSize = true;
            addMoreLabel.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            addMoreLabel.Location = new Point(6, 28);
            addMoreLabel.Name = "addMoreLabel";
            addMoreLabel.Size = new Size(112, 23);
            addMoreLabel.TabIndex = 8;
            addMoreLabel.Text = "Next Value";
            // 
            // addMoreTB
            // 
            addMoreTB.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addMoreTB.Location = new Point(163, 24);
            addMoreTB.Name = "addMoreTB";
            addMoreTB.Size = new Size(215, 27);
            addMoreTB.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(313, 265);
            button2.Name = "button2";
            button2.Size = new Size(116, 67);
            button2.TabIndex = 10;
            button2.Text = "Restart";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // initialValuesGB
            // 
            initialValuesGB.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            initialValuesGB.Controls.Add(firstValueLabel);
            initialValuesGB.Controls.Add(secondValueLabel);
            initialValuesGB.Controls.Add(firstValueText);
            initialValuesGB.Controls.Add(secondValueText);
            initialValuesGB.Location = new Point(45, 65);
            initialValuesGB.Name = "initialValuesGB";
            initialValuesGB.Size = new Size(384, 107);
            initialValuesGB.TabIndex = 11;
            initialValuesGB.TabStop = false;
            // 
            // addMoreGB
            // 
            addMoreGB.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addMoreGB.Controls.Add(addMoreLabel);
            addMoreGB.Controls.Add(addMoreTB);
            addMoreGB.Location = new Point(45, 171);
            addMoreGB.Name = "addMoreGB";
            addMoreGB.Size = new Size(384, 76);
            addMoreGB.TabIndex = 12;
            addMoreGB.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(478, 344);
            Controls.Add(button2);
            Controls.Add(addMoreGB);
            Controls.Add(initialValuesGB);
            Controls.Add(label4);
            Controls.Add(resultTextBox);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "AddNums";
            initialValuesGB.ResumeLayout(false);
            initialValuesGB.PerformLayout();
            addMoreGB.ResumeLayout(false);
            addMoreGB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label firstValueLabel;
        private Label secondValueLabel;
        private TextBox firstValueText;
        private TextBox secondValueText;
        private Button button1;
        private TextBox resultTextBox;
        private Label label4;
        private Label addMoreLabel;
        private TextBox addMoreTB;
        private Button button2;
        private GroupBox initialValuesGB;
        private GroupBox addMoreGB;
    }
}
