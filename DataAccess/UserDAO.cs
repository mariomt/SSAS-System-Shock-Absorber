using Dapper;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DataAccess
{
    public class UserDAO : DataAccessObjectBase
    {
        #region Constructores
        public UserDAO(IDbConnection pCon)
            :base(pCon)
        {

        }
        public UserDAO()
            :base(new SqlConnection(ConnectionString.getStringConnection()))
        {

        }

        #endregion
        public IDbConnection Connection
        {
            get
            {
                return this.dbConn;
            }
        }

        /// <summary>
        /// Consulta en la base de datos a un usuario con sus credenciales.
        /// </summary>
        /// <param name="pUser">Entidad de usuario con correo y password</param>
        /// <returns>Regesa un nuevo usuario</returns>
        public User logIn(User pUser)
        {
            try
            {
                var result = dbConn.Query<User, Rol, User>(Queries.selectUserByCredentials,
                    (user, rol) => { user.rol = rol; return user; }, new {
                        usuario = pUser.NombreUsuario, pass = pUser.Contrasena
                    }, splitOn: "UsuarioID,RolID").FirstOrDefault();

                if(result != null)
                {
                    result.Contrasena = string.Empty;
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void insertUser(User user)
        {
            //@NombreUsuario,@Contrasena,@Nombre,@ApellidoPaterno,@ApellidoMaterno,@RolID,@Activo
            dbConn.Execute(Queries.insertNewUser,
                new
                {
                    NombreUsuario = user.NombreUsuario,
                    Contrasena = user.Contrasena,
                    Nombre = user.Nombre,
                    ApellidoPaterno = user.ApellidoPaterno,
                    ApellidoMaterno = user.ApellidoMaterno,
                    RolID = user.rol.RolId,
                    Activo = user.Activo
                }
            );
        }

        public IEnumerable<User> searchUsers(string usuario)
        {
            var result = dbConn.Query<User, Rol,User>(  Queries.searchUsers, (user, rol) => { user.rol = rol; return user; },
                                                        new { NombreUsuario = usuario}, splitOn: "UsuarioID,RolID").ToList();
            return result;
        }

        public void updateUserByID(User user)
        {
            dbConn.Execute(Queries.updateUserByID,
                new 
                {
                    UsuarioID = user.UsuarioID,
                    NombreUsuario = user.NombreUsuario,
                    Contrasena = user.Contrasena,
                    Nombre = user.Nombre,
                    ApellidoPaterno = user.ApellidoPaterno,
                    ApellidoMaterno = user.ApellidoMaterno,
                    RolID = user.rol.RolId,
                    Activo = user.Activo
                }
            );
        }

        public void deleteUserByID(int UserID)
        {
            dbConn.Execute(Queries.deleteUserByID,
                new 
                {
                    UsuairoID=UserID
                }
            );
        }
    }
}
