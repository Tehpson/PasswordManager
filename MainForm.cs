namespace PasswordManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        private Form1 Loginform { get; set; }
        public MainForm(Form1 form1)
        {
            Loginform = form1;
            InitializeComponent();
            FillCombBox();
        }

        private void FillCombBox()
        {
            var data = Functions.GetLocalData.GetLocalFileData();
            getPWDDroppDown.DataSource = data.Data;
        }

        private void GeneratePWDbtn_Click(object sender, EventArgs e)
        {
            var password = Functions.CreateLocalData.GenerateAndStoreLocalData(genreatePWDAlias.Text);
            GenreatePasswrodResTbox.Text = password;
            FillCombBox();
        }

        private void GetPWDbtn_Click(object sender, EventArgs e)
        {
            getPWDtbx.Text = Functions.Hashing.DecryptPasswordOwn((Models.Data)getPWDDroppDown.SelectedItem);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Loginform.Close();
        }
    }
}
