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
            helpToolStripMenuItem = new ToolStripMenuItem();
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
            inputValueTB.Size = new Size(307, 27);
            inputValueTB.TabIndex = 3;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.LightSkyBlue;
            addBtn.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            addBtn.Location = new Point(45, 159);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(419, 38);
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
            resetBtn.Location = new Point(45, 433);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(419, 39);
            resetBtn.TabIndex = 10;
            resetBtn.Text = "Clear / Reset";
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += button2_Click;
            // 
            // totalSumLabel
            // 
            totalSumLabel.AutoSize = true;
            totalSumLabel.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            totalSumLabel.Location = new Point(45, 215);
            totalSumLabel.Name = "totalSumLabel";
            totalSumLabel.Size = new Size(145, 23);
            totalSumLabel.TabIndex = 11;
            totalSumLabel.Text = "Total Weight: ";
            // 
            // totalShimLabel
            // 
            totalShimLabel.AutoSize = true;
            totalShimLabel.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            totalShimLabel.Location = new Point(45, 258);
            totalShimLabel.Name = "totalShimLabel";
            totalShimLabel.Size = new Size(138, 23);
            totalShimLabel.TabIndex = 12;
            totalShimLabel.Text = "Total Shims: ";
            // 
            // undoBtn
            // 
            undoBtn.BackColor = Color.White;
            undoBtn.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            undoBtn.Location = new Point(45, 366);
            undoBtn.Name = "undoBtn";
            undoBtn.Size = new Size(419, 38);
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
            errorLabel.Location = new Point(45, 316);
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
            menu.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(503, 24);
            menu.TabIndex = 16;
            menu.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(47, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // shimAccumulator
            // 
            AcceptButton = addBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(503, 484);
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
        private ToolStripMenuItem helpToolStripMenuItem;
    }
}
