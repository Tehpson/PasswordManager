namespace PasswordManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Cheack Login info");
            var masterPWD = Functions.GetLocalData.GetMasterPWD();
            if (!masterPWD.StartsWith("ERROR"))
            {
                var PasswordSuccsesfull = Functions.Hashing.VerifyPasswordBcrypt(masterPasswordtbx.Text, masterPWD);
                if (PasswordSuccsesfull)
                {
                    using var mainfrom = new MainForm();
                    this.Hide();
                    mainfrom.ShowDialog();
                }
                else
                {
                    MessageBox.Show("WORONG PASSWORD");
                }
            }
            else
            {
                MessageBox.Show("Please create a new master password or recovere the backupfile", "NO FILE FOUND!!");
            }
        }

        private void CreateMasterPwdBtn_Click(object sender, EventArgs e)
        {
            if (createMasterPWD.Text != createMasterPWDRepeat.Text)
            {
                MessageBox.Show("password does not match");
            }
            else if (!Regex.IsMatch(createMasterPWD.Text, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$ %^&*-]).{8,}$"))
            {
                MessageBox.Show("password need to be atleast 8 charecter and have both number, small and big latter and special charecters");
            }
            else
            {
                var (sucssesfull, msg) = Functions.CreateLocalData.CreateMasterPassword(createMasterPWD.Text);
                if (!sucssesfull)
                {
                    MessageBox.Show(msg);
                }
                else
                {
                    using var mainfrom = new MainForm();
                    this.Hide();
                    mainfrom.ShowDialog();
                }
            }
        }
    }
}
