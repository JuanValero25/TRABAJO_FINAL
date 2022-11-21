﻿using BE;
using MPP;
using Servicios;

namespace BLL
{
    public class UsuarioBLL
    {

        public UsuarioXMLMPP mapper = new UsuarioXMLMPP();

        public Usuario GetUsuarioByDNIAndPassword(string DNI, string password)
        {

            var usuario = mapper.Get(DNI);

            if (usuario.ID == null)
            {
                return null;
            }

            if (usuario.password.Equals(password))
            {
                // set role for all enviroments
                RolesManager.getInstance().SetRolebyName(usuario.Role);

                if (RolesManager.getInstance().GetCurrentRole() == null)
                {
                    return null;
                }

                return usuario;
            }
            return null;

        }


    }
}