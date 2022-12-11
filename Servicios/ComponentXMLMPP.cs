using MPP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Servicios
{
    public class ComponentXMLMPP : XMLReflectionParser<Role>
    {

        public void saveRole(Role role)
        {
            if (!File.Exists(fileName))
            {
                var xdoc = new XDocument();
                var rootElement = new XElement(typeName + "s");
                xdoc.Add(rootElement);
                xdoc.Save(fileName);
            }

            if (GetRoleByName(role.name) != null)
            {
                eliminarRole(role.name);
            }

            XDocument xmlDoc = XDocument.Load(fileName);
            var element = xmlDoc.Element(Root);

            var roleElement = new XElement(role.name);
            var ListAccessos = new List<XElement>();

            foreach (var access in role.ObtenerHijos())
            {
                var AccesosUnit = new XElement(access.name);


                var ListPermisos = new List<XElement>();
                foreach (var permiso in access.ObtenerHijos())
                {
                    var PermisosUnit = new XElement(permiso.name);
                    ListPermisos.Add(PermisosUnit);

                }
                var rootPermisos = new XElement("permisos", ListPermisos.ToArray());
                AccesosUnit.Add(rootPermisos);


                ListAccessos.Add(AccesosUnit);

            }
            var rootAccesos = new XElement("accessos", ListAccessos.ToArray());
            roleElement.Add(rootAccesos);
            element.Add(roleElement);

            xmlDoc.Save(fileName);

        }

        public void eliminarRole(string RoleName)
        {
            XDocument xmlDoc = XDocument.Load(fileName);

            try
            {
                var ele = xmlDoc.Element(Root).Element(RoleName);
                ele.Remove();
                xmlDoc.Save(fileName);

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("no existe ningun objecto o no existe el archivo : " + fileName);

            }

        }

        public Role GetRoleByName(string RoleName)
        {
            XDocument xmlDoc = XDocument.Load(fileName);

            try
            {
                var ele = xmlDoc.Element(Root).Element(RoleName);

                if (ele == null)
                {

                    return null;
                }

                return ElementToRole(ele);

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("no existe ningun objecto o no existe el archivo : " + fileName);

            }

            return null;
        }

        public List<Role> GetAllRoles()
        {
            var ListRoles = new List<Role>();
            XDocument xmlDoc = XDocument.Load(fileName);

            try
            {
                var ele = xmlDoc.Element(Root).Elements();

                if (ele == null)
                {

                    return null;
                }



                foreach (var xmlRole in ele)
                {
                    ListRoles.Add(ElementToRole(xmlRole));


                }

                return ListRoles;

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("no existe ningun objecto o no existe el archivo : " + fileName);

            }

            return null;
        }

        public Role ElementToRole(XElement ele)
        {

            var RoleName = ele.Name.ToString();

            Role role = new Role(RoleName);


            foreach (var acesos in ele.Descendants("accessos").Elements())
            {

                var accesso = new Acceso(acesos.Name.ToString());

                foreach (var permiso in acesos.Descendants("permisos").Elements())
                {

                    var finalPermiso = new Permiso(permiso.Name.ToString());
                    accesso.agregarHijo(finalPermiso);
                }
                role.agregarHijo(accesso);




            }


            return role;
        }

        public bool ExisteRoles()
        {

            return File.Exists(fileName);
        }

    }
}
