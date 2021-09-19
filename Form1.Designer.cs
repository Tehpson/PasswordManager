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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
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
            this.masterPasswordtbx.Location = new System.Drawing.Point(65, 172);
            this.masterPasswordtbx.Name = "masterPasswordtbx";
            this.masterPasswordtbx.PasswordChar = '*';
            this.masterPasswordtbx.Size = new System.Drawing.Size(160, 23);
            this.masterPasswordtbx.TabIndex = 0;
            // 
            // Loginbtn
            // 
            this.Loginbtn.Location = new System.Drawing.Point(65, 210);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(160, 23);
            this.Loginbtn.TabIndex = 2;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // createMasterPwdBtn
            // 
            this.createMasterPwdBtn.Location = new System.Drawing.Point(536, 232);
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
            this.createMasterPWDRepeat.Location = new System.Drawing.Point(536, 190);
            this.createMasterPWDRepeat.Name = "createMasterPWDRepeat";
            this.createMasterPWDRepeat.PasswordChar = '*';
            this.createMasterPWDRepeat.Size = new System.Drawing.Size(160, 23);
            this.createMasterPWDRepeat.TabIndex = 3;
            // 
            // createMasterPWD
            // 
            this.createMasterPWD.BackColor = System.Drawing.Color.White;
            this.createMasterPWD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createMasterPWD.Location = new System.Drawing.Point(536, 143);
            this.createMasterPWD.Name = "createMasterPWD";
            this.createMasterPWD.PasswordChar = '*';
            this.createMasterPWD.Size = new System.Drawing.Size(160, 23);
            this.createMasterPWD.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Master Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Repeat master password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Master Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createMasterPWD);
            this.Controls.Add(this.createMasterPwdBtn);
            this.Controls.Add(this.createMasterPWDRepeat);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.masterPasswordtbx);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox createMasterPWD;
        private System.Windows.Forms.Button createMasterPwdBtn;
        private System.Windows.Forms.TextBox createMasterPWDRepeat;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.TextBox masterPasswordtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

