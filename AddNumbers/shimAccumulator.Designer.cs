namespace AddNumbers
{
    partial class shimAccumulator
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
            components = new System.ComponentModel.Container();
            appDescription = new Label();
            inputValueLabel = new Label();
            inputValueTB = new TextBox();
            addBtn = new Button();
            resetBtn = new Button();
            totalSumLabel = new Label();
            totalShimLabel = new Label();
            undoBtn = new Button();
            errorLabel = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripMenuItem1 = new ToolStripMenuItem();
            menu = new MenuStrip();
            helpMenuItem = new ToolStripMenuItem();
            aboutMenuItem = new ToolStripMenuItem();
            bundleLimitChangeToolStripMenuItem = new ToolStripMenuItem();
            saveAndPrintMenuItem = new ToolStripMenuItem();
            quitMenuItem = new ToolStripMenuItem();
            avgWeightLabel = new Label();
            avgWeightAmount = new Label();
            stdDeviationLabel = new Label();
            stdDeviationAmount = new Label();
            minWeightLabel = new Label();
            minWeightAmount = new Label();
            maxWeightLabel = new Label();
            maxWeightAmount = new Label();
            inputLabel = new Label();
            bundleLimitLabel = new Label();
            limitRemaining = new Label();
            contextMenuStrip1.SuspendLayout();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // appDescription
            // 
            appDescription.AutoSize = true;
            appDescription.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            appDescription.Location = new Point(45, 34);
            appDescription.Name = "appDescription";
            appDescription.Size = new Size(419, 29);
            appDescription.TabIndex = 0;
            appDescription.Text = "Shim Weight and Amount Counter";
            // 
            // inputValueLabel
            // 
            inputValueLabel.AutoSize = true;
            inputValueLabel.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            inputValueLabel.Location = new Point(45, 93);
            inputValueLabel.Name = "inputValueLabel";
            inputValueLabel.Size = new Size(106, 29);
            inputValueLabel.TabIndex = 1;
            inputValueLabel.Text = "Weight:";
            // 
            // inputValueTB
            // 
            inputValueTB.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inputValueTB.Location = new Point(157, 95);
            inputValueTB.Name = "inputValueTB";
            inputValueTB.Size = new Size(360, 27);
            inputValueTB.TabIndex = 3;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.LightSkyBlue;
            addBtn.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            addBtn.Location = new Point(45, 139);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(525, 38);
            addBtn.TabIndex = 5;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += button1_Click;
            // 
            // resetBtn
            // 
            resetBtn.BackColor = Color.Khaki;
            resetBtn.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            resetBtn.ForeColor = SystemColors.ActiveCaptionText;
            resetBtn.Location = new Point(45, 375);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(525, 39);
            resetBtn.TabIndex = 10;
            resetBtn.Text = "Clear / Reset";
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += button2_Click;
            // 
            // totalSumLabel
            // 
            totalSumLabel.AutoSize = true;
            totalSumLabel.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            totalSumLabel.Location = new Point(45, 190);
            totalSumLabel.Name = "totalSumLabel";
            totalSumLabel.Size = new Size(122, 18);
            totalSumLabel.TabIndex = 11;
            totalSumLabel.Text = "Total Weight: ";
            // 
            // totalShimLabel
            // 
            totalShimLabel.AutoSize = true;
            totalShimLabel.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            totalShimLabel.Location = new Point(390, 190);
            totalShimLabel.Name = "totalShimLabel";
            totalShimLabel.Size = new Size(115, 18);
            totalShimLabel.TabIndex = 12;
            totalShimLabel.Text = "Total Shims: ";
            // 
            // undoBtn
            // 
            undoBtn.BackColor = Color.White;
            undoBtn.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            undoBtn.Location = new Point(45, 321);
            undoBtn.Name = "undoBtn";
            undoBtn.Size = new Size(525, 38);
            undoBtn.TabIndex = 13;
            undoBtn.Text = "Undo Last";
            undoBtn.UseVisualStyleBackColor = false;
            undoBtn.Click += undoBtn_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(45, 284);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(60, 18);
            errorLabel.TabIndex = 14;
            errorLabel.Text = "Error: ";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBox1, toolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 51);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 23);
            toolStripTextBox1.Text = "Help";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(180, 22);
            toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // menu
            // 
            menu.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            menu.Items.AddRange(new ToolStripItem[] { helpMenuItem, aboutMenuItem, bundleLimitChangeToolStripMenuItem, saveAndPrintMenuItem, quitMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(612, 24);
            menu.TabIndex = 16;
            menu.Text = "menuStrip1";
            // 
            // helpMenuItem
            // 
            helpMenuItem.Name = "helpMenuItem";
            helpMenuItem.Size = new Size(47, 20);
            helpMenuItem.Text = "Help";
            helpMenuItem.Click += helpMenuItem_Click;
            // 
            // aboutMenuItem
            // 
            aboutMenuItem.Name = "aboutMenuItem";
            aboutMenuItem.Size = new Size(58, 20);
            aboutMenuItem.Text = "About";
            aboutMenuItem.Click += this.aboutMenuItem_Click;
            // 
            // bundleLimitChangeToolStripMenuItem
            // 
            bundleLimitChangeToolStripMenuItem.Name = "bundleLimitChangeToolStripMenuItem";
            bundleLimitChangeToolStripMenuItem.Size = new Size(151, 20);
            bundleLimitChangeToolStripMenuItem.Text = "Bundle Limit Change";
            bundleLimitChangeToolStripMenuItem.Click += bundleLimitChangeToolStripMenuItem_Click;
            // 
            // saveAndPrintMenuItem
            // 
            saveAndPrintMenuItem.Name = "saveAndPrintMenuItem";
            saveAndPrintMenuItem.Size = new Size(88, 20);
            saveAndPrintMenuItem.Text = "Save/Print";
            saveAndPrintMenuItem.Click += saveAndPrintMenuItem_Click;
            // 
            // quitMenuItem
            // 
            quitMenuItem.Name = "quitMenuItem";
            quitMenuItem.Size = new Size(46, 20);
            quitMenuItem.Text = "Quit";
            quitMenuItem.Click += quitMenuItem_Click;
            // 
            // avgWeightLabel
            // 
            avgWeightLabel.AutoSize = true;
            avgWeightLabel.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            avgWeightLabel.Location = new Point(47, 442);
            avgWeightLabel.Name = "avgWeightLabel";
            avgWeightLabel.Size = new Size(150, 14);
            avgWeightLabel.TabIndex = 17;
            avgWeightLabel.Text = "Average Weight (lbs)";
            // 
            // avgWeightAmount
            // 
            avgWeightAmount.AutoSize = true;
            avgWeightAmount.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            avgWeightAmount.Location = new Point(47, 466);
            avgWeightAmount.Name = "avgWeightAmount";
            avgWeightAmount.Size = new Size(16, 14);
            avgWeightAmount.TabIndex = 18;
            avgWeightAmount.Text = "0";
            // 
            // stdDeviationLabel
            // 
            stdDeviationLabel.AutoSize = true;
            stdDeviationLabel.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            stdDeviationLabel.Location = new Point(47, 504);
            stdDeviationLabel.Name = "stdDeviationLabel";
            stdDeviationLabel.Size = new Size(134, 14);
            stdDeviationLabel.TabIndex = 19;
            stdDeviationLabel.Text = "Standard Deviation";
            // 
            // stdDeviationAmount
            // 
            stdDeviationAmount.AutoSize = true;
            stdDeviationAmount.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            stdDeviationAmount.Location = new Point(47, 530);
            stdDeviationAmount.Name = "stdDeviationAmount";
            stdDeviationAmount.Size = new Size(16, 14);
            stdDeviationAmount.TabIndex = 20;
            stdDeviationAmount.Text = "0";
            // 
            // minWeightLabel
            // 
            minWeightLabel.AutoSize = true;
            minWeightLabel.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            minWeightLabel.Location = new Point(392, 442);
            minWeightLabel.Name = "minWeightLabel";
            minWeightLabel.Size = new Size(118, 14);
            minWeightLabel.TabIndex = 21;
            minWeightLabel.Text = "Min Weight (lbs)";
            // 
            // minWeightAmount
            // 
            minWeightAmount.AutoSize = true;
            minWeightAmount.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            minWeightAmount.Location = new Point(392, 466);
            minWeightAmount.Name = "minWeightAmount";
            minWeightAmount.Size = new Size(16, 14);
            minWeightAmount.TabIndex = 22;
            minWeightAmount.Text = "0";
            // 
            // maxWeightLabel
            // 
            maxWeightLabel.AutoSize = true;
            maxWeightLabel.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            maxWeightLabel.Location = new Point(392, 504);
            maxWeightLabel.Name = "maxWeightLabel";
            maxWeightLabel.Size = new Size(122, 14);
            maxWeightLabel.TabIndex = 23;
            maxWeightLabel.Text = "Max Weight (lbs)";
            // 
            // maxWeightAmount
            // 
            maxWeightAmount.AutoSize = true;
            maxWeightAmount.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            maxWeightAmount.Location = new Point(392, 530);
            maxWeightAmount.Name = "maxWeightAmount";
            maxWeightAmount.Size = new Size(16, 14);
            maxWeightAmount.TabIndex = 24;
            maxWeightAmount.Text = "0";
            // 
            // inputLabel
            // 
            inputLabel.AutoSize = true;
            inputLabel.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            inputLabel.Location = new Point(523, 93);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(47, 29);
            inputLabel.TabIndex = 25;
            inputLabel.Text = "lbs";
            // 
            // bundleLimitLabel
            // 
            bundleLimitLabel.AutoSize = true;
            bundleLimitLabel.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            bundleLimitLabel.Location = new Point(47, 237);
            bundleLimitLabel.Name = "bundleLimitLabel";
            bundleLimitLabel.Size = new Size(120, 18);
            bundleLimitLabel.TabIndex = 26;
            bundleLimitLabel.Text = "Bundle Limit: ";
            // 
            // limitRemaining
            // 
            limitRemaining.AutoSize = true;
            limitRemaining.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            limitRemaining.Location = new Point(390, 237);
            limitRemaining.Name = "limitRemaining";
            limitRemaining.Size = new Size(151, 18);
            limitRemaining.TabIndex = 27;
            limitRemaining.Text = "Limit Remaining: ";
            // 
            // shimAccumulator
            // 
            AcceptButton = addBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(612, 573);
            Controls.Add(limitRemaining);
            Controls.Add(bundleLimitLabel);
            Controls.Add(inputLabel);
            Controls.Add(maxWeightAmount);
            Controls.Add(maxWeightLabel);
            Controls.Add(minWeightAmount);
            Controls.Add(minWeightLabel);
            Controls.Add(stdDeviationAmount);
            Controls.Add(stdDeviationLabel);
            Controls.Add(avgWeightAmount);
            Controls.Add(avgWeightLabel);
            Controls.Add(menu);
            Controls.Add(errorLabel);
            Controls.Add(undoBtn);
            Controls.Add(totalShimLabel);
            Controls.Add(totalSumLabel);
            Controls.Add(inputValueTB);
            Controls.Add(inputValueLabel);
            Controls.Add(resetBtn);
            Controls.Add(addBtn);
            Controls.Add(appDescription);
            Name = "shimAccumulator";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Shim Accumulator";
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip1.PerformLayout();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label appDescription;
        private Label inputValueLabel;
        private TextBox inputValueTB;
        private Button addBtn;
        private Button resetBtn;
        private Label totalSumLabel;
        private Label totalShimLabel;
        private Button undoBtn;
        private Label errorLabel;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripMenuItem toolStripMenuItem1;
        private MenuStrip menu;
        private ToolStripMenuItem helpMenuItem;
        private ToolStripMenuItem saveAndPrintMenuItem;
        private ToolStripMenuItem quitMenuItem;
        private ToolStripMenuItem bundleLimitChangeToolStripMenuItem;
        private Label avgWeightLabel;
        private Label avgWeightAmount;
        private Label stdDeviationLabel;
        private Label stdDeviationAmount;
        private Label minWeightLabel;
        private Label minWeightAmount;
        private Label maxWeightLabel;
        private Label maxWeightAmount;
        private Label inputLabel;
        private Label bundleLimitLabel;
        private Label limitRemaining;
        private ToolStripMenuItem aboutMenuItem;
    }
}
