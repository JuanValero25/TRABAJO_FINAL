using Servicios;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TRABAJO_FINAL
{
    public partial class PermisosForm : Form
    {
        RolesManager roleManager = RolesManager.getInstance();
        ComponentXMLMPP mpp = new ComponentXMLMPP();

        public PermisosForm()
        {
            InitializeComponent();
            initViewTree();
        }

        private void initViewTree()
        {


            foreach (Role role in roleManager.GetAllRoles())
            {
                var RootNode = new TreeNode(role.name);
                RootNode.Checked = true;

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

                    RootNode.Nodes.Add(accessoTreeNode);
                }
                treeView1.Nodes.Add(RootNode);
            }

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }


        private List<Role> TrewwViewToRole()
        {
            var ListRoles = new List<Role>();

            foreach (TreeNode tnc in treeView1.Nodes)
            {
                Role role = new Role(tnc.Text);

                foreach (TreeNode accessNodes in tnc.Nodes)
                {
                    var acceso = new Acceso(accessNodes.Text);
                    foreach (TreeNode PermisionNode in accessNodes.Nodes)
                    {
                        if (PermisionNode.Checked && accessNodes.Checked) {
                            var permision = new Permiso(PermisionNode.Text);
                            acceso.agregarHijo(permision);
                        }
                    }
                    if (accessNodes.Checked)
                    {
                        role.agregarHijo(acceso);
                    }
                }
                ListRoles.Add(role);

            }

            return ListRoles;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var roles = TrewwViewToRole();

            foreach (Role role in roles)
            {

                mpp.saveRole(role);
            }


        }

        private void AgregarRole_Click(object sender, System.EventArgs e)
        {
            var name = RoleName.Text;

            var RootNode = new TreeNode(name);
            RootNode.Checked = true;

            foreach (string acceso in roleManager.GetAllAccessos())
            {
                var accessoTreeNode = new TreeNode(acceso);

                foreach (string permiso in roleManager.GetPermisosName())
                {
                    var permisoNode = new TreeNode(permiso);
                    accessoTreeNode.Nodes.Add(permisoNode);
                }
                RootNode.Nodes.Add(accessoTreeNode);
            }

            treeView1.Nodes.Add(RootNode);
        }
    }
}
