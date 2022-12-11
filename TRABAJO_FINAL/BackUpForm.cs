using Servicios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TRABAJO_FINAL
{
    public partial class BackUpForm : Form
    {
        private BackUpService bk = new BackUpService();

        public BackUpForm(Role role)
        {
            InitializeComponent();
            renderBictacora();
        }

        private void BackupButton_Click(object sender, EventArgs e)
        {

            bk.CreateBackup();
            renderBictacora();

        }

        private void RestoreButton_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                bk.RestoreBackup(openFileDialog1.FileName);
                renderBictacora();
            }

        }

        private void renderBictacora() {

            var usuariList = this.bk.GetAll();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = usuariList;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkOrange;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
