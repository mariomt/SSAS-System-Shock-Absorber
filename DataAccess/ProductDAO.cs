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

    }
}
