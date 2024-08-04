namespace AddNumbers
{
    partial class quitForm
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
            quitLabel = new Label();
            yesBtn = new Button();
            noBtn = new Button();
            SuspendLayout();
            // 
            // quitLabel
            // 
            quitLabel.AutoSize = true;
            quitLabel.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            quitLabel.Location = new Point(22, 18);
            quitLabel.Name = "quitLabel";
            quitLabel.Size = new Size(335, 25);
            quitLabel.TabIndex = 0;
            quitLabel.Text = "Are you sure you want to quit?";
            quitLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // yesBtn
            // 
            yesBtn.BackColor = Color.LightGreen;
            yesBtn.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            yesBtn.Location = new Point(35, 71);
            yesBtn.Name = "yesBtn";
            yesBtn.Size = new Size(126, 39);
            yesBtn.TabIndex = 3;
            yesBtn.Text = "Yes";
            yesBtn.UseVisualStyleBackColor = false;
            yesBtn.Click += yesBtn_Click;
            // 
            // noBtn
            // 
            noBtn.BackColor = Color.LightCoral;
            noBtn.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            noBtn.Location = new Point(204, 71);
            noBtn.Name = "noBtn";
            noBtn.Size = new Size(126, 39);
            noBtn.TabIndex = 4;
            noBtn.Text = "No";
            noBtn.UseVisualStyleBackColor = false;
            noBtn.Click += noBtn_Click;
            // 
            // quitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 135);
            Controls.Add(noBtn);
            Controls.Add(yesBtn);
            Controls.Add(quitLabel);
            Name = "quitForm";
            Text = "Quit?";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label quitLabel;
        private Button yesBtn;
        private Button noBtn;
    }
}