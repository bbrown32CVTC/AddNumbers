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
            inputValueLabel = new Label();
            inputValueTB = new TextBox();
            addBtn = new Button();
            totalSumTB = new TextBox();
            label4 = new Label();
            resetBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(427, 35);
            label1.TabIndex = 0;
            label1.Text = "Simple App to Add Numbers";
            // 
            // inputValueLabel
            // 
            inputValueLabel.AutoSize = true;
            inputValueLabel.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            inputValueLabel.Location = new Point(45, 93);
            inputValueLabel.Name = "inputValueLabel";
            inputValueLabel.Size = new Size(149, 29);
            inputValueLabel.TabIndex = 1;
            inputValueLabel.Text = "Input Value";
            // 
            // inputValueTB
            // 
            inputValueTB.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inputValueTB.Location = new Point(214, 95);
            inputValueTB.Name = "inputValueTB";
            inputValueTB.Size = new Size(215, 27);
            inputValueTB.TabIndex = 3;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.LightSkyBlue;
            addBtn.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            addBtn.Location = new Point(45, 159);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(97, 57);
            addBtn.TabIndex = 5;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += button1_Click;
            // 
            // totalSumTB
            // 
            totalSumTB.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            totalSumTB.Location = new Point(214, 189);
            totalSumTB.Name = "totalSumTB";
            totalSumTB.Size = new Size(215, 27);
            totalSumTB.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(264, 159);
            label4.Name = "label4";
            label4.Size = new Size(89, 18);
            label4.TabIndex = 7;
            label4.Text = "Total Sum";
            // 
            // resetBtn
            // 
            resetBtn.BackColor = Color.Red;
            resetBtn.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            resetBtn.ForeColor = SystemColors.ButtonHighlight;
            resetBtn.Location = new Point(45, 242);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(384, 57);
            resetBtn.TabIndex = 10;
            resetBtn.Text = "Clear / Reset";
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += button2_Click;
            // 
            // Form1
            // 
            AcceptButton = addBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(478, 311);
            Controls.Add(inputValueTB);
            Controls.Add(inputValueLabel);
            Controls.Add(resetBtn);
            Controls.Add(label4);
            Controls.Add(totalSumTB);
            Controls.Add(addBtn);
            Controls.Add(label1);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Accumulator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label inputValueLabel;
        private TextBox inputValueTB;
        private Button addBtn;
        private TextBox totalSumTB;
        private Label label4;
        private Button resetBtn;
    }
}
