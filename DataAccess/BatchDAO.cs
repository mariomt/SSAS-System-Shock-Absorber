using Dapper;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BatchDAO: DataAccessObjectBase
    {
        #region Constructores
        public BatchDAO(IDbConnection pCon)
            : base(pCon)
        {

        }
        public BatchDAO()
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
