using Servicios;
using System.Windows.Forms;

namespace TRABAJO_FINAL
{
    public partial class PermisosForm : Form
    {
        RolesManager roleManager = RolesManager.getInstance();

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

                foreach (var accesso in role.ObtenerHijos())
                {
                    var accessoTreeNode = new TreeNode(accesso.name);
                    RootNode.Nodes.Add(accessoTreeNode);

                    foreach (var permisos in accesso.ObtenerHijos())
                    {
                        var permisoNode = new TreeNode(permisos.name);
                        accessoTreeNode.Nodes.Add(permisoNode);

                    }

                }
                treeView1.Nodes.Add(RootNode);
            }

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
