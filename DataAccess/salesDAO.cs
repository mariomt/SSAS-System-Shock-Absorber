

using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class salesDAO : DataAccessObjectBase
    {
        #region Constructores
        public salesDAO(IDbConnection pCon)
            : base(pCon)
        {

        }
        public salesDAO()
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

    }
}
