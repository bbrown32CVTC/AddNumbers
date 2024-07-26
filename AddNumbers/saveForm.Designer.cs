namespace AddNumbers
{
    partial class saveForm
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
            writeBtn = new Button();
            saveAsBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // writeBtn
            // 
            writeBtn.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            writeBtn.Location = new Point(52, 27);
            writeBtn.Name = "writeBtn";
            writeBtn.Size = new Size(140, 67);
            writeBtn.TabIndex = 0;
            writeBtn.Text = "Write";
            writeBtn.UseVisualStyleBackColor = true;
            writeBtn.Click += writeBtn_Click;
            // 
            // saveAsBtn
            // 
            saveAsBtn.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            saveAsBtn.Location = new Point(52, 125);
            saveAsBtn.Name = "saveAsBtn";
            saveAsBtn.Size = new Size(140, 64);
            saveAsBtn.TabIndex = 1;
            saveAsBtn.Text = "Save As";
            saveAsBtn.UseVisualStyleBackColor = true;
            saveAsBtn.Click += saveAsBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cancelBtn.ForeColor = Color.Red;
            cancelBtn.Location = new Point(52, 281);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(140, 36);
            cancelBtn.TabIndex = 2;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // saveForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 329);
            Controls.Add(cancelBtn);
            Controls.Add(saveAsBtn);
            Controls.Add(writeBtn);
            Name = "saveForm";
            Text = "Save Options";
            ResumeLayout(false);
        }

        #endregion

        private Button writeBtn;
        private Button saveAsBtn;
        private Button cancelBtn;
    }
}