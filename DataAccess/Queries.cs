

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
        public const string selectUserByCredentials = @"SELECT UsuarioID, us.Correo, us.Contrasena, us.Activo, rl.RolID, rl.Descripcion 
                                                        FROM Usuarios as us INNER JOIN Roles as rl ON us.RolID=rl.RolID 
                                                        WHERE Correo=@email AND Contrasena=@pass";

        #endregion

        #region Productos
        // Escribe las consultas de productos aquí...
        //para insertar un nuevo producto
        public const string insertNewProduct = @"INSERT INTO Productos(Descripcion,PrecioVenta,Disponibilidad,IVA,Activo) VALUES(@Descripcion,@PrecioVenta,@Disponibilidad,@IVA,@Activo)";
        #endregion
        public const string selectAllProduct = @"SELECT ProductoID,Descripcion,PrecioVenta,
                                                Disponibilidad,IVA,Activo FROM Productos";

        public const string searchProductsBydescription = @"SELECT ProductoID,Descripcion,PrecioVenta,Disponibilidad,IVA,Activo FROM Productos where Descripcion LIKE @product";


        #region Servicios
        // Escribe las consultas de Servicios quí...
        public const string selectAllServices = @"SELECT ServicioID, Nombre, Descripcion, Activo FROM Servicios";
        #endregion

        #region Ventas
        // Escribe las consultas de ventas aquí...

        #endregion
    }
}
