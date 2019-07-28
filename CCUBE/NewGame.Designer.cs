namespace CCUBE
{
    partial class NewGame
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.player1Box = new System.Windows.Forms.GroupBox();
            this.player2Box = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.doneBtn = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.selectBtn1 = new System.Windows.Forms.Button();
            this.selectBtn2 = new System.Windows.Forms.Button();
            this.player1Box.SuspendLayout();
            this.player2Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many players?";
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Location = new System.Drawing.Point(169, 24);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(31, 17);
            this.radio1.TabIndex = 1;
            this.radio1.Text = "1";
            this.radio1.UseVisualStyleBackColor = true;
            this.radio1.CheckedChanged += new System.EventHandler(this.radio1_CheckedChanged);
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Location = new System.Drawing.Point(222, 24);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(31, 17);
            this.radio2.TabIndex = 2;
            this.radio2.Text = "2";
            this.radio2.UseVisualStyleBackColor = true;
            this.radio2.CheckedChanged += new System.EventHandler(this.radio2_CheckedChanged);
            // 
            // player1Box
            // 
            this.player1Box.Controls.Add(this.selectBtn1);
            this.player1Box.Controls.Add(this.button1);
            this.player1Box.Location = new System.Drawing.Point(12, 94);
            this.player1Box.Name = "player1Box";
            this.player1Box.Size = new System.Drawing.Size(228, 185);
            this.player1Box.TabIndex = 3;
            this.player1Box.TabStop = false;
            this.player1Box.Text = "Player 1";
            // 
            // player2Box
            // 
            this.player2Box.Controls.Add(this.selectBtn2);
            this.player2Box.Controls.Add(this.button2);
            this.player2Box.Location = new System.Drawing.Point(246, 94);
            this.player2Box.Name = "player2Box";
            this.player2Box.Size = new System.Drawing.Size(233, 185);
            this.player2Box.TabIndex = 4;
            this.player2Box.TabStop = false;
            this.player2Box.Text = "Player 2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(128, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(209, 374);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(75, 23);
            this.doneBtn.TabIndex = 5;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // selectBtn1
            // 
            this.selectBtn1.Location = new System.Drawing.Point(20, 48);
            this.selectBtn1.Name = "selectBtn1";
            this.selectBtn1.Size = new System.Drawing.Size(75, 23);
            this.selectBtn1.TabIndex = 2;
            this.selectBtn1.Text = "Select";
            this.selectBtn1.UseVisualStyleBackColor = true;
            this.selectBtn1.Click += new System.EventHandler(this.selectBtn1_Click);
            // 
            // selectBtn2
            // 
            this.selectBtn2.Location = new System.Drawing.Point(18, 48);
            this.selectBtn2.Name = "selectBtn2";
            this.selectBtn2.Size = new System.Drawing.Size(75, 23);
            this.selectBtn2.TabIndex = 4;
            this.selectBtn2.Text = "Select";
            this.selectBtn2.UseVisualStyleBackColor = true;
            this.selectBtn2.Click += new System.EventHandler(this.selectBtn2_Click);
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 409);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.player2Box);
            this.Controls.Add(this.player1Box);
            this.Controls.Add(this.radio2);
            this.Controls.Add(this.radio1);
            this.Controls.Add(this.label1);
            this.Name = "NewGame";
            this.Text = "NewGame";
            this.Load += new System.EventHandler(this.NewGame_Load);
            this.player1Box.ResumeLayout(false);
            this.player2Box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.GroupBox player1Box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox player2Box;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.Button selectBtn1;
        private System.Windows.Forms.Button selectBtn2;
    }
}