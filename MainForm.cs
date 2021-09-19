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
        public MainForm()
        {
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

        private void getPWDbtn_Click(object sender, EventArgs e)
        {
            getPWDtbx.Text = Functions.Hashing.DecryptPasswordOwn((Models.Data)getPWDDroppDown.SelectedItem);
        }
    }
}
