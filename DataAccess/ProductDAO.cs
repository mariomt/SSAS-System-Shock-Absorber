using Dapper;
using Entities;
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
    }
}
