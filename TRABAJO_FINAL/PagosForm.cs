using Servicios;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TRABAJO_FINAL
{
    public partial class PagosForm : Form
    {
        public PagosForm(Role role)
        {
            InitializeComponent();
            renderByRole(role);
        }

        private void renderByRole(Role role)
        {
            var Accessos = role.ObtenerHijos().Where(h => h.name.Equals("PAGOS"));


            foreach (Permiso p in Accessos.First().ObtenerHijos())
            {
                switch (p.name)
                {
                    case "AGREGAR_MODIFICAR":
                        PagarButton.Enabled = true;
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
