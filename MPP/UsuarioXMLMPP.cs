using BE;
using Servicios;
using System.Windows.Forms;

namespace MPP
{
    public class UsuarioXMLMPP : XMLReflectionParser<Usuario>
    {
        RolesManager roleManager = RolesManager.getInstance();

        public UsuarioXMLMPP()
        {
            var user = this.Get("999555111");
            if (user.DNI == null)
            {
                // super admin no fue creado, creando...

                var superAdmin = new Usuario();
                superAdmin.DNI = "999555111";
                superAdmin.ID = "999555111";
                superAdmin.password = EncryptionService.EncryptString("fancy_password");
                superAdmin.Role = roleManager.GetRoleByName("ADMIN").name;
                Save(superAdmin);

                MessageBox.Show("inicializando app Usuario Super Admin Creado");


                var Cliente = new Usuario();
                Cliente.DNI = "999222111";
                Cliente.ID = "999222111";
                Cliente.password = EncryptionService.EncryptString("1234");
                Cliente.Role = roleManager.GetRoleByName("CLIENTE").name;
                Save(Cliente);


                MessageBox.Show("inicializando app Usuario Test Cliente");

            }


        }


    }
}
