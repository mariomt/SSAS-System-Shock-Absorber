using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class DataAccessObjectBase : IDisposable
    {

        protected IDbConnection dbConn = null;

        public DataAccessObjectBase(IDbConnection pConn)
        {
            if (pConn == null)
                throw new ArgumentNullException("The -pConn- parameter must not be a null.");
            dbConn = pConn;
        }

        public DataAccessObjectBase(SqlConnection pConn)
        {
            if (pConn == null)
                throw new ArgumentNullException("The -pConn- parameter must not be a null.");
            dbConn = pConn;
        }

        ~DataAccessObjectBase()
        {
            Dispose(false);
        }



        #region disposing
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (dbConn != null)
                {
                    if (dbConn.State != ConnectionState.Closed)
                        dbConn.Close();

                    dbConn.Dispose();
                    dbConn = null;
                }
            }
        }

        #endregion
    }
}
