namespace CCUBE
{
    partial class SelectPlayer
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
            this.okbtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.playersCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // okbtn
            // 
            this.okbtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okbtn.Location = new System.Drawing.Point(103, 270);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(75, 23);
            this.okbtn.TabIndex = 0;
            this.okbtn.Text = "Ok";
            this.okbtn.UseVisualStyleBackColor = true;
            this.okbtn.Click += new System.EventHandler(this.okbtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(188, 270);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // playersCombo
            // 
            this.playersCombo.FormattingEnabled = true;
            this.playersCombo.Location = new System.Drawing.Point(37, 47);
            this.playersCombo.Name = "playersCombo";
            this.playersCombo.Size = new System.Drawing.Size(221, 21);
            this.playersCombo.TabIndex = 2;
            this.playersCombo.SelectionChangeCommitted += new System.EventHandler(this.playersCombo_SelectionChangeCommitted);
            // 
            // SelectPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 305);
            this.Controls.Add(this.playersCombo);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okbtn);
            this.Name = "SelectPlayer";
            this.Text = "SelectPlayer";
            this.Load += new System.EventHandler(this.SelectPlayer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okbtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ComboBox playersCombo;
    }
}