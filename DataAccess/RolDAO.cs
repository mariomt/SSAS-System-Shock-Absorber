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
    public class RolDAO : DataAccessObjectBase
    {
        #region Constructores
        public RolDAO(IDbConnection pCon)
            : base(pCon)
        {

        }
        public RolDAO()
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

        public IEnumerable<Rol> getAll()
        {
            return dbConn.Query<Rol>(Queries.selectAllRoles).ToList();
        }
    }

    
}
