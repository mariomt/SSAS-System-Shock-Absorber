using Dapper;
using Entities;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DataAccess
{
    public class ProductDAO : DataAccessObjectBase
    {
        #region Constructores
        public ProductDAO(IDbConnection pCon)
            : base(pCon)
        {

        }
        public ProductDAO()
            : base(new SqlConnection(ConnectionString.getStringConnection()))
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

        public void insertProduct(Product product)
        {
            dbConn.Execute(Queries.insertNewProduct,
                new
                {
                    Descripcion = product.Descripcion,
                    PrecioVenta = product.PrecioVenta,
                    Disponibilidad = product.Disponibilidad,
                    IVA = product.IVA,
                    Activo = product.Activo
                }
            );

        }

        public IEnumerable<Product> getProdcts()
        {
            return dbConn.Query<Product>(Queries.selectAllProduct).ToList();

                
        }
        public IEnumerable<Product> SearchProducts(string parametro)
        {
             
            return dbConn.Query<Product>(Queries.searchProductsBydescription,new { product = "%" + parametro + "%"}).ToList();
        }

        public bool bajaproducto(Product bajap, IDbTransaction transaccion)
        {
            return dbConn.Execute(Queries.BajaProducto, new {
                active = bajap.Activo,
                id = bajap.ProductoID
                
            }, transaccion) >0;
        }

        public bool updateProduct(Product pProduct, IDbTransaction pTransaction = null)
        {
            return dbConn.Execute(Queries.updateProduct, new 
            {
                prodID = pProduct.ProductoID,
                desc = pProduct.Descripcion,
                pVenta= pProduct.PrecioVenta,
                disp = pProduct.Disponibilidad,
                iva = pProduct.IVA,
                act = pProduct.Activo
            }, pTransaction) > 0;
        }

        /// <summary>
        /// Actualiza la cantidad disponible del producto especificado.
        /// </summary>
        /// <param name="productoID">Valor entero que representa el identificador del producto</param>
        /// <param name="cantidad">Valor entero que se le sumara o restará al producto dependiendo de su signo</param>
        /// <param name="pTransaction">Si se le pasa una transacción la consulta formara parte de ella y no se verá reflejada hasta que la transacción se complete.</param>
        /// <returns>Regresa true si se modifica al menos un registro y false si no se modifica ningún registro.</returns>
        public bool updateDisponibilidad(int productoID, int cantidad, IDbTransaction pTransaction = null)
        {
            return dbConn.Execute(@"UPDATE Productos SET Disponibilidad=Disponibilidad+@disp WHERE ProductoID=@id", new
            {
                id = productoID,
                disp = cantidad
            }, pTransaction) > 0;
        }
    }
}
