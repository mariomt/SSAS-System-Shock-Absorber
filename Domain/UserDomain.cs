﻿using DataAccess;
using Entities;


namespace Domain
{
    /// <summary>
    /// Clase que contiene todas las acciones que se pueden hacer con los usuarios.
    /// </summary>
    public class UserDomain
    {
        /// <summary>
        /// Método para loguear al usuario ante el sistema.
        /// </summary>
        /// <param name="user">Entidad de usuario con correo y password setiados</param>
        public bool logIn(ref User user)
        {
            User newUser = new UserDAO().logIn(user);
            if(newUser!= null)
            {
                user.UsuarioID = newUser.UsuarioID;
                user.Contrasena = "";
                user.Activo = newUser.Activo;
                user.rol = newUser.rol;
                return true;
            }
            return false;
        }

    }
}
