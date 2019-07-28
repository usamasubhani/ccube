namespace CCUBE
{
    partial class MainForm
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
            this.registerBox = new System.Windows.Forms.GroupBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.cnicLabel = new System.Windows.Forms.Label();
            this.cnicTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.t1Box = new System.Windows.Forms.GroupBox();
            this.t2Box = new System.Windows.Forms.GroupBox();
            this.t3Box = new System.Windows.Forms.GroupBox();
            this.t4Box = new System.Windows.Forms.GroupBox();
            this.t5Box = new System.Windows.Forms.GroupBox();
            this.t6Box = new System.Windows.Forms.GroupBox();
            this.t7Box = new System.Windows.Forms.GroupBox();
            this.t8Box = new System.Windows.Forms.GroupBox();
            this.t9Box = new System.Windows.Forms.GroupBox();
            this.requestGameBtn = new System.Windows.Forms.Button();
            this.declareResultBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.updateStatusTimer = new System.Windows.Forms.Timer(this.components);
            this.t1busyLabel = new System.Windows.Forms.Label();
            this.t2Busy = new System.Windows.Forms.Label();
            this.t3Busy = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.t5Busy = new System.Windows.Forms.Label();
            this.t6Busy = new System.Windows.Forms.Label();
            this.t7Busy = new System.Windows.Forms.Label();
            this.t8Busy = new System.Windows.Forms.Label();
            this.t9Busy = new System.Windows.Forms.Label();
            this.registerBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.t1Box.SuspendLayout();
            this.t2Box.SuspendLayout();
            this.t3Box.SuspendLayout();
            this.t4Box.SuspendLayout();
            this.t5Box.SuspendLayout();
            this.t6Box.SuspendLayout();
            this.t7Box.SuspendLayout();
            this.t8Box.SuspendLayout();
            this.t9Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // registerBox
            // 
            this.registerBox.Controls.Add(this.registerBtn);
            this.registerBox.Controls.Add(this.cnicLabel);
            this.registerBox.Controls.Add(this.cnicTextBox);
            this.registerBox.Controls.Add(this.nameTextBox);
            this.registerBox.Controls.Add(this.label1);
            this.registerBox.Location = new System.Drawing.Point(12, 12);
            this.registerBox.Name = "registerBox";
            this.registerBox.Size = new System.Drawing.Size(200, 239);
            this.registerBox.TabIndex = 1;
            this.registerBox.TabStop = false;
            this.registerBox.Text = "Register Player";
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(81, 128);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(75, 23);
            this.registerBtn.TabIndex = 4;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // cnicLabel
            // 
            this.cnicLabel.AutoSize = true;
            this.cnicLabel.Location = new System.Drawing.Point(16, 68);
            this.cnicLabel.Name = "cnicLabel";
            this.cnicLabel.Size = new System.Drawing.Size(32, 13);
            this.cnicLabel.TabIndex = 3;
            this.cnicLabel.Text = "CNIC";
            // 
            // cnicTextBox
            // 
            this.cnicTextBox.Location = new System.Drawing.Point(57, 68);
            this.cnicTextBox.Name = "cnicTextBox";
            this.cnicTextBox.Size = new System.Drawing.Size(100, 20);
            this.cnicTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(57, 42);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.t1Box);
            this.flowLayoutPanel1.Controls.Add(this.t2Box);
            this.flowLayoutPanel1.Controls.Add(this.t3Box);
            this.flowLayoutPanel1.Controls.Add(this.t4Box);
            this.flowLayoutPanel1.Controls.Add(this.t5Box);
            this.flowLayoutPanel1.Controls.Add(this.t6Box);
            this.flowLayoutPanel1.Controls.Add(this.t7Box);
            this.flowLayoutPanel1.Controls.Add(this.t8Box);
            this.flowLayoutPanel1.Controls.Add(this.t9Box);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(246, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(624, 332);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // t1Box
            // 
            this.t1Box.Controls.Add(this.t1busyLabel);
            this.t1Box.Location = new System.Drawing.Point(3, 3);
            this.t1Box.Name = "t1Box";
            this.t1Box.Size = new System.Drawing.Size(200, 100);
            this.t1Box.TabIndex = 0;
            this.t1Box.TabStop = false;
            this.t1Box.Text = "T-1";
            // 
            // t2Box
            // 
            this.t2Box.Controls.Add(this.t2Busy);
            this.t2Box.Location = new System.Drawing.Point(209, 3);
            this.t2Box.Name = "t2Box";
            this.t2Box.Size = new System.Drawing.Size(200, 100);
            this.t2Box.TabIndex = 1;
            this.t2Box.TabStop = false;
            this.t2Box.Text = "T-2";
            // 
            // t3Box
            // 
            this.t3Box.Controls.Add(this.t3Busy);
            this.t3Box.Location = new System.Drawing.Point(415, 3);
            this.t3Box.Name = "t3Box";
            this.t3Box.Size = new System.Drawing.Size(200, 100);
            this.t3Box.TabIndex = 2;
            this.t3Box.TabStop = false;
            this.t3Box.Text = "T-3";
            // 
            // t4Box
            // 
            this.t4Box.Controls.Add(this.label4);
            this.t4Box.Location = new System.Drawing.Point(3, 109);
            this.t4Box.Name = "t4Box";
            this.t4Box.Size = new System.Drawing.Size(200, 100);
            this.t4Box.TabIndex = 3;
            this.t4Box.TabStop = false;
            this.t4Box.Text = "T-4";
            // 
            // t5Box
            // 
            this.t5Box.Controls.Add(this.t5Busy);
            this.t5Box.Location = new System.Drawing.Point(209, 109);
            this.t5Box.Name = "t5Box";
            this.t5Box.Size = new System.Drawing.Size(200, 100);
            this.t5Box.TabIndex = 4;
            this.t5Box.TabStop = false;
            this.t5Box.Text = "T-5";
            // 
            // t6Box
            // 
            this.t6Box.Controls.Add(this.t6Busy);
            this.t6Box.Location = new System.Drawing.Point(415, 109);
            this.t6Box.Name = "t6Box";
            this.t6Box.Size = new System.Drawing.Size(200, 100);
            this.t6Box.TabIndex = 5;
            this.t6Box.TabStop = false;
            this.t6Box.Text = "T-6";
            // 
            // t7Box
            // 
            this.t7Box.Controls.Add(this.t7Busy);
            this.t7Box.Location = new System.Drawing.Point(3, 215);
            this.t7Box.Name = "t7Box";
            this.t7Box.Size = new System.Drawing.Size(200, 100);
            this.t7Box.TabIndex = 6;
            this.t7Box.TabStop = false;
            this.t7Box.Text = "T-7";
            // 
            // t8Box
            // 
            this.t8Box.Controls.Add(this.t8Busy);
            this.t8Box.Location = new System.Drawing.Point(209, 215);
            this.t8Box.Name = "t8Box";
            this.t8Box.Size = new System.Drawing.Size(200, 100);
            this.t8Box.TabIndex = 7;
            this.t8Box.TabStop = false;
            this.t8Box.Text = "T-8";
            // 
            // t9Box
            // 
            this.t9Box.Controls.Add(this.t9Busy);
            this.t9Box.Location = new System.Drawing.Point(415, 215);
            this.t9Box.Name = "t9Box";
            this.t9Box.Size = new System.Drawing.Size(200, 100);
            this.t9Box.TabIndex = 8;
            this.t9Box.TabStop = false;
            this.t9Box.Text = "T-9";
            // 
            // requestGameBtn
            // 
            this.requestGameBtn.Location = new System.Drawing.Point(3, 278);
            this.requestGameBtn.Name = "requestGameBtn";
            this.requestGameBtn.Size = new System.Drawing.Size(69, 49);
            this.requestGameBtn.TabIndex = 3;
            this.requestGameBtn.Text = "New Game";
            this.requestGameBtn.UseVisualStyleBackColor = true;
            this.requestGameBtn.Click += new System.EventHandler(this.requestGameBtn_Click);
            // 
            // declareResultBtn
            // 
            this.declareResultBtn.Location = new System.Drawing.Point(78, 278);
            this.declareResultBtn.Name = "declareResultBtn";
            this.declareResultBtn.Size = new System.Drawing.Size(75, 49);
            this.declareResultBtn.TabIndex = 4;
            this.declareResultBtn.Text = "End Game";
            this.declareResultBtn.UseVisualStyleBackColor = true;
            this.declareResultBtn.Click += new System.EventHandler(this.declareResultBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(161, 278);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 49);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // updateStatusTimer
            // 
            this.updateStatusTimer.Enabled = true;
            this.updateStatusTimer.Interval = 1000;
            this.updateStatusTimer.Tick += new System.EventHandler(this.updateStatusTimer_Tick);
            // 
            // t1busyLabel
            // 
            this.t1busyLabel.AutoSize = true;
            this.t1busyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t1busyLabel.Location = new System.Drawing.Point(97, 39);
            this.t1busyLabel.Name = "t1busyLabel";
            this.t1busyLabel.Size = new System.Drawing.Size(0, 25);
            this.t1busyLabel.TabIndex = 0;
            // 
            // t2Busy
            // 
            this.t2Busy.AutoSize = true;
            this.t2Busy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t2Busy.Location = new System.Drawing.Point(100, 38);
            this.t2Busy.Name = "t2Busy";
            this.t2Busy.Size = new System.Drawing.Size(0, 25);
            this.t2Busy.TabIndex = 1;
            // 
            // t3Busy
            // 
            this.t3Busy.AutoSize = true;
            this.t3Busy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t3Busy.Location = new System.Drawing.Point(100, 38);
            this.t3Busy.Name = "t3Busy";
            this.t3Busy.Size = new System.Drawing.Size(0, 25);
            this.t3Busy.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 1;
            // 
            // t5Busy
            // 
            this.t5Busy.AutoSize = true;
            this.t5Busy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t5Busy.Location = new System.Drawing.Point(100, 38);
            this.t5Busy.Name = "t5Busy";
            this.t5Busy.Size = new System.Drawing.Size(0, 25);
            this.t5Busy.TabIndex = 1;
            // 
            // t6Busy
            // 
            this.t6Busy.AutoSize = true;
            this.t6Busy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t6Busy.Location = new System.Drawing.Point(100, 38);
            this.t6Busy.Name = "t6Busy";
            this.t6Busy.Size = new System.Drawing.Size(0, 25);
            this.t6Busy.TabIndex = 1;
            // 
            // t7Busy
            // 
            this.t7Busy.AutoSize = true;
            this.t7Busy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t7Busy.Location = new System.Drawing.Point(100, 38);
            this.t7Busy.Name = "t7Busy";
            this.t7Busy.Size = new System.Drawing.Size(0, 25);
            this.t7Busy.TabIndex = 1;
            // 
            // t8Busy
            // 
            this.t8Busy.AutoSize = true;
            this.t8Busy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t8Busy.Location = new System.Drawing.Point(100, 38);
            this.t8Busy.Name = "t8Busy";
            this.t8Busy.Size = new System.Drawing.Size(0, 25);
            this.t8Busy.TabIndex = 1;
            // 
            // t9Busy
            // 
            this.t9Busy.AutoSize = true;
            this.t9Busy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t9Busy.Location = new System.Drawing.Point(100, 38);
            this.t9Busy.Name = "t9Busy";
            this.t9Busy.Size = new System.Drawing.Size(0, 25);
            this.t9Busy.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.declareResultBtn);
            this.Controls.Add(this.requestGameBtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.registerBox);
            this.Name = "MainForm";
            this.Text = "CCUBE";
            this.registerBox.ResumeLayout(false);
            this.registerBox.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.t1Box.ResumeLayout(false);
            this.t1Box.PerformLayout();
            this.t2Box.ResumeLayout(false);
            this.t2Box.PerformLayout();
            this.t3Box.ResumeLayout(false);
            this.t3Box.PerformLayout();
            this.t4Box.ResumeLayout(false);
            this.t4Box.PerformLayout();
            this.t5Box.ResumeLayout(false);
            this.t5Box.PerformLayout();
            this.t6Box.ResumeLayout(false);
            this.t6Box.PerformLayout();
            this.t7Box.ResumeLayout(false);
            this.t7Box.PerformLayout();
            this.t8Box.ResumeLayout(false);
            this.t8Box.PerformLayout();
            this.t9Box.ResumeLayout(false);
            this.t9Box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox registerBox;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label cnicLabel;
        private System.Windows.Forms.TextBox cnicTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox t1Box;
        private System.Windows.Forms.GroupBox t2Box;
        private System.Windows.Forms.GroupBox t3Box;
        private System.Windows.Forms.GroupBox t4Box;
        private System.Windows.Forms.GroupBox t5Box;
        private System.Windows.Forms.GroupBox t6Box;
        private System.Windows.Forms.GroupBox t7Box;
        private System.Windows.Forms.GroupBox t8Box;
        private System.Windows.Forms.GroupBox t9Box;
        private System.Windows.Forms.Button requestGameBtn;
        private System.Windows.Forms.Button declareResultBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Timer updateStatusTimer;
        private System.Windows.Forms.Label t1busyLabel;
        private System.Windows.Forms.Label t2Busy;
        private System.Windows.Forms.Label t3Busy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label t5Busy;
        private System.Windows.Forms.Label t6Busy;
        private System.Windows.Forms.Label t7Busy;
        private System.Windows.Forms.Label t8Busy;
        private System.Windows.Forms.Label t9Busy;

    }
}

