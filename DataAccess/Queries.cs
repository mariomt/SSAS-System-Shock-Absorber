﻿

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
        public const string selectUserByCredentials = @"SELECT us.UsuarioID, us.NombreUsuario, us.Contrasena,us.Nombre,us.ApellidoPaterno,us.ApellidoMaterno, us.Activo, rl.RolID, rl.Descripcion 
                                                        FROM Usuarios as us INNER JOIN Roles as rl ON us.RolID=rl.RolID 
                                                        WHERE us.NombreUsuario=@usuario AND us.Contrasena=@pass";

        #endregion

        #region Productos
        // Escribe las consultas de productos aquí...
        //para insertar un nuevo producto
        public const string insertNewProduct = @"INSERT INTO Productos(Descripcion,PrecioVenta,Disponibilidad,IVA,Activo) VALUES(@Descripcion,@PrecioVenta,@Disponibilidad,@IVA,@Activo)";
        public const string selectAllProduct = @"SELECT ProductoID,Descripcion,PrecioVenta, Disponibilidad,IVA,Activo FROM Productos";
        public const string searchProductsBydescription = @"SELECT ProductoID,Descripcion,PrecioVenta,Disponibilidad,IVA,Activo FROM Productos where Descripcion LIKE @product";
        public const string  BajaProducto = @"UPDATE Productos SET Activo=@active WHERE ProductoID=@id";
        #endregion


        #region Servicios
        // Escribe las consultas de Servicios quí...
        public const string selectAllServices = @"SELECT ServicioID, Nombre, Descripcion, Activo FROM Servicios";
        public const string selectServicesByName = @"SELECT ServicioID, Nombre, Descripcion, Activo FROM Servicios WHERE Nombre LIKE @service";
        public const string disablService = @"UPDATE Servicios SET Activo=@active WHERE ServicioID=@id";
        public const string insertService = @"INSERT INTO Servicios(Nombre, Descripcion, Activo) VALUES(@name,@description,@active)";
        #endregion

        #region Ventas
        // Escribe las consultas de ventas aquí...


        #endregion

        #region Lotes
        // Escribe las consultas de Lotes aquí...
        public const string insertBatch = @"INSERT INTO LoteProducto(ProductoID,FechaHora,Importe,Cantidad,Activo) VALUES(@ProductoID,@FechaHora,@Importe,@Cantidad,@Activo)";
        #endregion
    }
}
