namespace PasswordManager
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.masterPasswordtbx = new System.Windows.Forms.TextBox();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.createMasterPwdBtn = new System.Windows.Forms.Button();
            this.createMasterPWDRepeat = new System.Windows.Forms.TextBox();
            this.createMasterPWD = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // masterPasswordtbx
            // 
            this.masterPasswordtbx.BackColor = System.Drawing.Color.White;
            this.masterPasswordtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.masterPasswordtbx.Location = new System.Drawing.Point(21, 24);
            this.masterPasswordtbx.Name = "masterPasswordtbx";
            this.masterPasswordtbx.PasswordChar = '*';
            this.masterPasswordtbx.PlaceholderText = "Master Password";
            this.masterPasswordtbx.Size = new System.Drawing.Size(160, 23);
            this.masterPasswordtbx.TabIndex = 0;
            // 
            // Loginbtn
            // 
            this.Loginbtn.Location = new System.Drawing.Point(21, 62);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(160, 23);
            this.Loginbtn.TabIndex = 2;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // createMasterPwdBtn
            // 
            this.createMasterPwdBtn.Location = new System.Drawing.Point(21, 100);
            this.createMasterPwdBtn.Name = "createMasterPwdBtn";
            this.createMasterPwdBtn.Size = new System.Drawing.Size(160, 23);
            this.createMasterPwdBtn.TabIndex = 4;
            this.createMasterPwdBtn.Text = "Create Password";
            this.createMasterPwdBtn.UseVisualStyleBackColor = true;
            this.createMasterPwdBtn.Click += new System.EventHandler(this.CreateMasterPwdBtn_Click);
            // 
            // createMasterPWDRepeat
            // 
            this.createMasterPWDRepeat.BackColor = System.Drawing.Color.White;
            this.createMasterPWDRepeat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createMasterPWDRepeat.Location = new System.Drawing.Point(21, 62);
            this.createMasterPWDRepeat.Name = "createMasterPWDRepeat";
            this.createMasterPWDRepeat.PasswordChar = '*';
            this.createMasterPWDRepeat.PlaceholderText = "repeat master password";
            this.createMasterPWDRepeat.Size = new System.Drawing.Size(160, 23);
            this.createMasterPWDRepeat.TabIndex = 3;
            // 
            // createMasterPWD
            // 
            this.createMasterPWD.BackColor = System.Drawing.Color.White;
            this.createMasterPWD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createMasterPWD.Location = new System.Drawing.Point(21, 22);
            this.createMasterPWD.Name = "createMasterPWD";
            this.createMasterPWD.PasswordChar = '*';
            this.createMasterPWD.PlaceholderText = "Master Password";
            this.createMasterPWD.Size = new System.Drawing.Size(160, 23);
            this.createMasterPWD.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createMasterPwdBtn);
            this.groupBox1.Controls.Add(this.createMasterPWD);
            this.groupBox1.Controls.Add(this.createMasterPWDRepeat);
            this.groupBox1.Location = new System.Drawing.Point(15, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 140);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Account";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Loginbtn);
            this.groupBox2.Controls.Add(this.masterPasswordtbx);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 286);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(243, 325);
            this.MinimumSize = new System.Drawing.Size(243, 325);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox createMasterPWD;
        private System.Windows.Forms.Button createMasterPwdBtn;
        private System.Windows.Forms.TextBox createMasterPWDRepeat;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.TextBox masterPasswordtbx;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

