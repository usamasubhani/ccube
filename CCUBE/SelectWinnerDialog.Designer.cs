namespace CCUBE
{
    partial class SelectWinnerDialog
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
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.p1Radio = new System.Windows.Forms.RadioButton();
            this.p2Radio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.Location = new System.Drawing.Point(63, 173);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 0;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(144, 173);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // p1Radio
            // 
            this.p1Radio.AutoSize = true;
            this.p1Radio.Location = new System.Drawing.Point(34, 38);
            this.p1Radio.Name = "p1Radio";
            this.p1Radio.Size = new System.Drawing.Size(14, 13);
            this.p1Radio.TabIndex = 2;
            this.p1Radio.TabStop = true;
            this.p1Radio.UseVisualStyleBackColor = true;
            // 
            // p2Radio
            // 
            this.p2Radio.AutoSize = true;
            this.p2Radio.Location = new System.Drawing.Point(34, 91);
            this.p2Radio.Name = "p2Radio";
            this.p2Radio.Size = new System.Drawing.Size(14, 13);
            this.p2Radio.TabIndex = 3;
            this.p2Radio.TabStop = true;
            this.p2Radio.UseVisualStyleBackColor = true;
            // 
            // SelectWinnerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 208);
            this.Controls.Add(this.p2Radio);
            this.Controls.Add(this.p1Radio);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Name = "SelectWinnerDialog";
            this.Text = "SelectWinnerDialog";
            this.Load += new System.EventHandler(this.SelectWinnerDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.RadioButton p1Radio;
        private System.Windows.Forms.RadioButton p2Radio;
    }
}