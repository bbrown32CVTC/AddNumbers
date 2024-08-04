namespace AddNumbers
{
    partial class changeLimitForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            changeLabel = new Label();
            changeAmountTB = new TextBox();
            approveBtn = new Button();
            cancelBtn = new Button();
            errorLabel = new Label();
            SuspendLayout();
            // 
            // changeLabel
            // 
            changeLabel.AutoSize = true;
            changeLabel.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            changeLabel.Location = new Point(36, 26);
            changeLabel.Name = "changeLabel";
            changeLabel.Size = new Size(255, 16);
            changeLabel.TabIndex = 0;
            changeLabel.Text = "Update bundle limit amount (lbs)?";
            // 
            // changeAmountTB
            // 
            changeAmountTB.Location = new Point(36, 72);
            changeAmountTB.Name = "changeAmountTB";
            changeAmountTB.Size = new Size(255, 23);
            changeAmountTB.TabIndex = 1;
            // 
            // approveBtn
            // 
            approveBtn.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            approveBtn.Location = new Point(36, 118);
            approveBtn.Name = "approveBtn";
            approveBtn.Size = new Size(117, 32);
            approveBtn.TabIndex = 2;
            approveBtn.Text = "Approve";
            approveBtn.UseVisualStyleBackColor = false;
            approveBtn.Click += ApproveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cancelBtn.Location = new Point(174, 118);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(117, 32);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += CancelBtn_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(36, 172);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(52, 16);
            errorLabel.TabIndex = 15;
            errorLabel.Text = "Error: ";
            // 
            // changeLimitForm
            // 
            AcceptButton = approveBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(321, 208);
            Controls.Add(errorLabel);
            Controls.Add(cancelBtn);
            Controls.Add(approveBtn);
            Controls.Add(changeAmountTB);
            Controls.Add(changeLabel);
            Name = "changeLimitForm";
            Text = "Bundle Limit Change";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label changeLabel;
        private TextBox changeAmountTB;
        private Button approveBtn = new Button();
        private Button cancelBtn = new Button();
        private Label errorLabel;
    }
}