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

    }
}
