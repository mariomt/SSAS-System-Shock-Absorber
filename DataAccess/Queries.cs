

namespace DataAccess
{
    /// <summary>
    /// En esta clase se encuentran todas las consultas que se realizaran hacia la base de datos
    /// </summary>
    public static class Queries
    {

        #region Usuarios
        /// <summary>
        /// Consulta para buscar un usuario por su correo y contraseña.
        /// </summary>
        public const string selectUserByCredentials = @"SELECT  UsuarioID, Correo, Contrasena, RolID, Activo FROM Usuarios WHERE Correo=@email AND Contrasena=@pass";

        #endregion

        #region Productos
        // Escribe las consultas de productos quí...

        #endregion

        #region Servicios
        // Escribe las consultas de Servicios quí...

        #endregion

        #region Ventas
        // Escribe las consultas de ventas aquí...

        #endregion
    }
}
