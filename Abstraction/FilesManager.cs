using Abstraction;

namespace MPP
{
    public class FilesManager
    {


        public FileResponse CreateFileFromEntity(IEntidad entidad)
        {
            /*
            XDocument xmlDoc = XDocument.Load("usuarios.xml");
            var element = xmlDoc.Element("Usuarios");
            element.Add(new XElement("Usuario",
                                     new XElement("ID", UsuarioNew.ID == null ? UsuarioNew.generateID() : UsuarioNew.ID.Trim()),
                                     new XElement("Nombre", UsuarioNew.Nombre.Trim()),
                                     new XElement("Codigo", UsuarioNew.Codigo.Trim()),
                                     new XElement("Apellido", UsuarioNew.Apellido.Trim()),
                                     new XElement("DNI", UsuarioNew.DNI.Trim()),
                                     new XElement("Email", UsuarioNew.Email.Trim()),
                                     new XElement("FechaDeNacimiento", UsuarioNew.FechaDeNacimiento.ToString("d", CultureInfo.GetCultureInfo("es-ES"))),
                                     new XElement("Localidad", UsuarioNew.Localidad),
                                     new XElement("Puntos", UsuarioNew.Puntos)
                                     ));

            xmlDoc.Save("usuarios.xml");

            */
            return null;
        }

    }
}
