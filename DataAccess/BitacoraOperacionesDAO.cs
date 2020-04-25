using Dapper;
using Entities;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class BitacoraOperacionesDAO : DataAccessObjectBase
    {
        public BitacoraOperacionesDAO(IDbConnection pCon) : base(pCon){ }
        public BitacoraOperacionesDAO(): base(new SqlConnection(ConnectionString.getStringConnection())) {}

        public IDbConnection Connection
        {
            get
            {
                return this.dbConn;
            }
        }

        public bool Save(BitacoraOperaciones pBitacoraOp, IDbTransaction pTransaction = null)
        {
            return dbConn.Execute(@"INSERT INTO BitacoraOperaciones(TipoID, UsuarioID,Comentario) VALUES(@tipo, @usuario, @comentario)", new
            {
                tipo = pBitacoraOp.TipoID,
                usuario = pBitacoraOp.UsuarioID,
                comentario = pBitacoraOp.Comentario
            },pTransaction) > 0;
        }

    }
}
