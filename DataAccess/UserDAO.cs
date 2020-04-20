using Dapper;
using Entities;
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
    }
}
