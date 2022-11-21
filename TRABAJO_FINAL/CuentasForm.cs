using BE;
using BLL;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRABAJO_FINAL
{
    public partial class CuentasForm : Form
    {
        private UsuarioBLL usuarioBLL = new UsuarioBLL();
        private RolesManager roleM = RolesManager.getInstance();

        public CuentasForm(Role role)
        {
            InitializeComponent();
            InitiRoleCombo();
        }

        private void InitiRoleCombo() {
            RoleCombo.Items.AddRange(roleM.GetAllRoles().Select(r=>r.name).ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (UsuarioDNIText.Text == "") {

                MessageBox.Show("usuario no puede estar vacio");
            }

            if (PasswordText.Text == "")
            {

                MessageBox.Show("password no puede estar vacio");
            }

            if (RoleCombo.SelectedItem == null )
            {

                MessageBox.Show("debe selecionar un role no puede estar vacio");
            }

            var usuario = new Usuario() {
            DNI = UsuarioDNIText.Text,
            ID = UsuarioDNIText.Text,
            Role = RoleCombo.SelectedItem.ToString(),
            password =    EncryptionService.EncryptString(PasswordText.Text)
            };

            this.usuarioBLL.GuardarUsuario(usuario);
        }

        private void ListarButton_Click(object sender, EventArgs e)
        {
            var usuariList = this.usuarioBLL.GetAllUsuarios();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = usuariList;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkOrange;
        }
    }
}
