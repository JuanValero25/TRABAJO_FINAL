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
    public partial class UserViewForm : Form
    {
        RolesManager roleManager = RolesManager.getInstance();
        UsuarioBLL usuarioBLL = new UsuarioBLL();
        public UserViewForm()
        {
            InitializeComponent();
            initViewTree();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            initViewTree();
        }

        private void initViewTree()
        {

            var allUsuario = usuarioBLL.GetAllUsuarios();
                 
            //roleManager
            foreach (var usuario in allUsuario)
            {


                var RootNode = new TreeNode(usuario.DNI);
                RootNode.Checked = true;

             var role =   roleManager.GetRoleByName(usuario.Role);

                var roleTreeNode = new TreeNode(role.name);
                RootNode.Nodes.Add(roleTreeNode);



                foreach (string acceso in roleManager.GetAllAccessos())
                {
                    var accessoTreeNode = new TreeNode(acceso);

                    var AccesoEncontrado = role.ObtenerHijos().Find(h => h.name.Equals(acceso));

                    if (AccesoEncontrado != null)
                    {
                        accessoTreeNode.Checked = true;
                    }

                    foreach (string permiso in roleManager.GetPermisosName())
                    {
                        var permisoNode = new TreeNode(permiso);
                        accessoTreeNode.Nodes.Add(permisoNode);

                        if (AccesoEncontrado == null)
                        {
                            continue;
                        }

                        var PermisoEncontrado = AccesoEncontrado.ObtenerHijos().Find(h => h.name.Equals(permiso));

                        if (PermisoEncontrado != null)
                        {
                            permisoNode.Checked = true;

                        }


                    }

                    roleTreeNode.Nodes.Add(accessoTreeNode);
                }
                treeView1.Nodes.Add(RootNode);
            }

        }
    }
}
