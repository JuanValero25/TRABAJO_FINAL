using Servicios;
using System;
using System.Windows.Forms;

namespace TRABAJO_FINAL
{
    public partial class BackUpForm : Form
    {
        private BackUpService bk = new BackUpService();

        public BackUpForm(Role role)
        {
            InitializeComponent();
        }

        private void BackupButton_Click(object sender, EventArgs e)
        {

            bk.CreateBackup();

        }

        private void RestoreButton_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                bk.RestereBackup(openFileDialog1.FileName);
                MessageBox.Show("backup completo");
            }

        }
    }
}
