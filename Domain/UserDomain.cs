using DataAccess;
using Entities;
using System.Collections.Generic;

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
                user.NombreUsuario = newUser.NombreUsuario;
                user.Contrasena = "";
                user.Nombre = newUser.Nombre;
                user.ApellidoPaterno = newUser.ApellidoPaterno;
                user.ApellidoMaterno = newUser.ApellidoMaterno;
                user.Activo = newUser.Activo;
                user.rol = newUser.rol;
                return true;
            }
            return false;
        }
        public void insertNewUser(ref User user)
        {
            new UserDAO().insertUser(user);

        }

        public IEnumerable<User> searchUsers(ref string usuario)
        {
            return new UserDAO().searchUsers(usuario);
        }

        public void updateUserByID(ref User user)
        {
            new UserDAO().updateUserByID(user);
        }

        public void deleteUserByID(ref int UserID)
        {
            new UserDAO().deleteUserByID(UserID);
        }

    }
}
