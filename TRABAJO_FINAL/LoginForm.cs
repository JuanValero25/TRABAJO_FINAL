using BLL;
using Servicios;
using System;
using System.Windows.Forms;

namespace TRABAJO_FINAL
{
    public partial class LoginForm : Form
    {

        private UsuarioBLL userBll = new UsuarioBLL();
        private InitialForm initForm;

        public LoginForm(InitialForm initForm)
        {
            InitializeComponent();
            this.initForm = initForm;
        }

        private void LogingButton_Click(object sender, EventArgs e)
        {


            var dni = DniTextBox.Text;
            var password = EncryptionService.EncryptString(PasswordTextBox.Text);

            var user = userBll.GetUsuarioByDNIAndPassword(dni, password);

            if (user == null)
            {
                MessageBox.Show("Usuario invalido");
                return;
            }



            this.initForm.EnableMenuToolTips();
            this.Close();


        }

        private void TestClientButton_Click(object sender, EventArgs e)
        {
            DniTextBox.Text = "999222111";
            PasswordTextBox.Text = "1234";
        }

        private void SuperAdminButton_Click(object sender, EventArgs e)
        {
            DniTextBox.Text = "999555111";
            PasswordTextBox.Text = "fancy_password";
        }

        private void Profesor_Click(object sender, EventArgs e)
        {

            DniTextBox.Text = "555222333";
            PasswordTextBox.Text = "el_profe";
        }
    }
}
