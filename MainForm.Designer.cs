namespace PasswordManager
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
            this.getPwdBox = new System.Windows.Forms.GroupBox();
            this.getPWDbtn = new System.Windows.Forms.Button();
            this.getPWDtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.getPWDDroppDown = new System.Windows.Forms.ComboBox();
            this.genreatePwdBox = new System.Windows.Forms.GroupBox();
            this.GenreatePasswrodResTbox = new System.Windows.Forms.TextBox();
            this.generatePWDbtn = new System.Windows.Forms.Button();
            this.genreatePWDAlias = new System.Windows.Forms.TextBox();
            this.getPwdBox.SuspendLayout();
            this.genreatePwdBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // getPwdBox
            // 
            this.getPwdBox.Controls.Add(this.getPWDbtn);
            this.getPwdBox.Controls.Add(this.getPWDtbx);
            this.getPwdBox.Controls.Add(this.label1);
            this.getPwdBox.Controls.Add(this.getPWDDroppDown);
            this.getPwdBox.Location = new System.Drawing.Point(12, 190);
            this.getPwdBox.Name = "getPwdBox";
            this.getPwdBox.Size = new System.Drawing.Size(200, 165);
            this.getPwdBox.TabIndex = 3;
            this.getPwdBox.TabStop = false;
            this.getPwdBox.Text = "Get Password";
            // 
            // getPWDbtn
            // 
            this.getPWDbtn.Location = new System.Drawing.Point(18, 82);
            this.getPWDbtn.Name = "getPWDbtn";
            this.getPWDbtn.Size = new System.Drawing.Size(160, 23);
            this.getPWDbtn.TabIndex = 3;
            this.getPWDbtn.Text = "Get password";
            this.getPWDbtn.UseVisualStyleBackColor = true;
            this.getPWDbtn.Click += new System.EventHandler(this.GetPWDbtn_Click);
            // 
            // getPWDtbx
            // 
            this.getPWDtbx.Location = new System.Drawing.Point(18, 121);
            this.getPWDtbx.Name = "getPWDtbx";
            this.getPWDtbx.PlaceholderText = "Your Password";
            this.getPWDtbx.ReadOnly = true;
            this.getPWDtbx.Size = new System.Drawing.Size(160, 23);
            this.getPWDtbx.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alias:";
            // 
            // getPWDDroppDown
            // 
            this.getPWDDroppDown.FormattingEnabled = true;
            this.getPWDDroppDown.Location = new System.Drawing.Point(18, 42);
            this.getPWDDroppDown.Name = "getPWDDroppDown";
            this.getPWDDroppDown.Size = new System.Drawing.Size(160, 23);
            this.getPWDDroppDown.TabIndex = 0;
            // 
            // genreatePwdBox
            // 
            this.genreatePwdBox.Controls.Add(this.GenreatePasswrodResTbox);
            this.genreatePwdBox.Controls.Add(this.generatePWDbtn);
            this.genreatePwdBox.Controls.Add(this.genreatePWDAlias);
            this.genreatePwdBox.Location = new System.Drawing.Point(12, 6);
            this.genreatePwdBox.Name = "genreatePwdBox";
            this.genreatePwdBox.Size = new System.Drawing.Size(200, 160);
            this.genreatePwdBox.TabIndex = 2;
            this.genreatePwdBox.TabStop = false;
            this.genreatePwdBox.Text = "Generate new Password";
            // 
            // GenreatePasswrodResTbox
            // 
            this.GenreatePasswrodResTbox.Location = new System.Drawing.Point(18, 114);
            this.GenreatePasswrodResTbox.Name = "GenreatePasswrodResTbox";
            this.GenreatePasswrodResTbox.PlaceholderText = "Your new Password";
            this.GenreatePasswrodResTbox.ReadOnly = true;
            this.GenreatePasswrodResTbox.Size = new System.Drawing.Size(160, 23);
            this.GenreatePasswrodResTbox.TabIndex = 2;
            // 
            // generatePWDbtn
            // 
            this.generatePWDbtn.Location = new System.Drawing.Point(18, 71);
            this.generatePWDbtn.Name = "generatePWDbtn";
            this.generatePWDbtn.Size = new System.Drawing.Size(160, 23);
            this.generatePWDbtn.TabIndex = 1;
            this.generatePWDbtn.Text = "Generate Password";
            this.generatePWDbtn.UseVisualStyleBackColor = true;
            this.generatePWDbtn.Click += new System.EventHandler(this.GeneratePWDbtn_Click);
            // 
            // genreatePWDAlias
            // 
            this.genreatePWDAlias.Location = new System.Drawing.Point(18, 31);
            this.genreatePWDAlias.Name = "genreatePWDAlias";
            this.genreatePWDAlias.PlaceholderText = "Alias";
            this.genreatePWDAlias.Size = new System.Drawing.Size(160, 23);
            this.genreatePWDAlias.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 367);
            this.Controls.Add(this.getPwdBox);
            this.Controls.Add(this.genreatePwdBox);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Password Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.getPwdBox.ResumeLayout(false);
            this.getPwdBox.PerformLayout();
            this.genreatePwdBox.ResumeLayout(false);
            this.genreatePwdBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox getPwdBox;
        private System.Windows.Forms.GroupBox genreatePwdBox;
        private System.Windows.Forms.Button generatePWDbtn;
        private System.Windows.Forms.TextBox genreatePWDAlias;
        private System.Windows.Forms.TextBox GenreatePasswrodResTbox;
        private System.Windows.Forms.TextBox getPWDtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getPWDbtn;
        private System.Windows.Forms.ComboBox getPWDDroppDown;
    }
}