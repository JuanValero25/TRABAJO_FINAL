using System.Collections.Generic;
using System.Linq;

namespace Servicios
{
    public class RolesManager
    {

        private static RolesManager instance;

        private List<Role> Roles = new List<Role>();

        private Role currentRole;


        private RolesManager()
        {

            var agregarYmodificar = new Permiso("AGREGAR_MODIFICAR");
            var Eliminar = new Permiso("ELIMINAR");
            var Listar = new Permiso("LISTAR");

            // permisos Admin para la vista Alumnos 
            var AlumnosAccesoAdmin = new Acceso("ALUMNOS");
            AlumnosAccesoAdmin.agregarHijo(agregarYmodificar);
            AlumnosAccesoAdmin.agregarHijo(Eliminar);
            AlumnosAccesoAdmin.agregarHijo(Listar);

            // Permisos para alumno de la vista de Alumnos
            var AlumnosAccesoClient = new Acceso("ALUMNOS");
            AlumnosAccesoClient.agregarHijo(Listar);

            // permisos para Profesores Admin
            var ProfesorAccesoAdmin = new Acceso("PROFESORES");
            ProfesorAccesoAdmin.agregarHijo(agregarYmodificar);
            ProfesorAccesoAdmin.agregarHijo(Eliminar);
            ProfesorAccesoAdmin.agregarHijo(Listar);

            // Permisos para Client de la vista de Profesores
            var ProfesorAccesoClient = new Acceso("PROFESORES");
            ProfesorAccesoClient.agregarHijo(Listar);


            // permisos para Cursos de alumnos Admin
            var InscripcionAccesoAdmin = new Acceso("INSCRIPCION");
            InscripcionAccesoAdmin.agregarHijo(agregarYmodificar);
            InscripcionAccesoAdmin.agregarHijo(Eliminar);
            InscripcionAccesoAdmin.agregarHijo(Listar);

            // Permisos para Cursos de alumnos client
            var InscripcionAccesoClient = new Acceso("INSCRIPCION");
            InscripcionAccesoClient.agregarHijo(agregarYmodificar);
            InscripcionAccesoClient.agregarHijo(Eliminar);
            InscripcionAccesoClient.agregarHijo(Listar);

            // permisos para Cursos Admin
            var CursosAccesoAdmin = new Acceso("CURSOS");
            CursosAccesoAdmin.agregarHijo(agregarYmodificar);
            CursosAccesoAdmin.agregarHijo(Eliminar);
            CursosAccesoAdmin.agregarHijo(Listar);

            // Permisos para Client de la vista de Cursos
            var CursosAccesoClient = new Acceso("CURSOS");
            CursosAccesoClient.agregarHijo(Listar);

            // permisos para Materias Admin
            var MateriasAccesoAdmin = new Acceso("MATERIAS");
            MateriasAccesoAdmin.agregarHijo(agregarYmodificar);
            MateriasAccesoAdmin.agregarHijo(Eliminar);
            MateriasAccesoAdmin.agregarHijo(Listar);

            // Permisos para Client de la vista de Materias
            var MateriasAccesoClient = new Acceso("MATERIAS");
            MateriasAccesoClient.agregarHijo(Listar);

            // permisos para Pagos Admin
            var PagosAccesoAdmin = new Acceso("PAGOS");
            PagosAccesoAdmin.agregarHijo(agregarYmodificar);
            PagosAccesoAdmin.agregarHijo(Listar);

            var PermisosAccesoAdmin = new Acceso("PERMISOS");
            PagosAccesoAdmin.agregarHijo(agregarYmodificar);
            PagosAccesoAdmin.agregarHijo(Listar);

            var BackupAccesoAdmin = new Acceso("PACKUP_AND_RESTORE");
            BackupAccesoAdmin.agregarHijo(agregarYmodificar);
            BackupAccesoAdmin.agregarHijo(Listar);

            var CuentasAccesoAdmin = new Acceso("CUENTAS");
            CuentasAccesoAdmin.agregarHijo(agregarYmodificar);
            CuentasAccesoAdmin.agregarHijo(Listar);


            // permisos para Login Admin
            var LoginAccesoAdmin = new Acceso("LOGIN");
            LoginAccesoAdmin.agregarHijo(agregarYmodificar);
            LoginAccesoAdmin.agregarHijo(Eliminar);
            LoginAccesoAdmin.agregarHijo(Listar);

            // Permisos para Client de la vista de Login
            var LoginAccesoClient = new Acceso("LOGIN");
            LoginAccesoAdmin.agregarHijo(Listar);


            var AdminRole = new Role("ADMIN");
            AdminRole.agregarHijo(AlumnosAccesoAdmin);
            AdminRole.agregarHijo(ProfesorAccesoAdmin);
            AdminRole.agregarHijo(InscripcionAccesoAdmin);
            AdminRole.agregarHijo(MateriasAccesoAdmin);
            AdminRole.agregarHijo(PagosAccesoAdmin);
            AdminRole.agregarHijo(LoginAccesoAdmin);
            AdminRole.agregarHijo(CursosAccesoAdmin);
            AdminRole.agregarHijo(PermisosAccesoAdmin);
            AdminRole.agregarHijo(BackupAccesoAdmin);
            AdminRole.agregarHijo(CuentasAccesoAdmin);





            var ClientRole = new Role("CLIENTE");
            ClientRole.agregarHijo(AlumnosAccesoClient);
            ClientRole.agregarHijo(ProfesorAccesoClient);
            ClientRole.agregarHijo(InscripcionAccesoClient);
            ClientRole.agregarHijo(MateriasAccesoClient);
            ClientRole.agregarHijo(LoginAccesoClient);
            ClientRole.agregarHijo(CursosAccesoClient);

            Roles.Add(AdminRole);
            Roles.Add(ClientRole);

        }

        public static RolesManager getInstance()
        {

            if (instance == null)
            {

                instance = new RolesManager();
            }

            return instance;
        }

        public Role GetRoleByName(string roleName)
        {
            return this.Roles.Where(r => r.name.Equals(roleName)).First();
        }

        public Role GetCurrentRole()
        {
            return this.currentRole;
        }

        public List<Role> GetAllRoles()
        {

            return this.Roles;
        }

        public void SetRolebyName(string roleName)
        {
            this.currentRole = GetRoleByName(roleName);
        }
    }
}
