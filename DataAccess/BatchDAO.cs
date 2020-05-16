using Dapper;
using Entities;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace DataAccess
{
    public class BatchDAO : DataAccessObjectBase
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
        public bool insertBatch(Batch batch, IDbTransaction pTransaction = null)
        {
            return dbConn.Execute(Queries.insertBatch,
                new
                {
                    ProductoID = batch.ProductoID,
                    FechaHora = batch.FechaHora,
                    Importe = batch.Importe,
                    Cantidad = batch.Cantidad,
                    Activo = batch.Activo
                }, pTransaction
            ) > 0;
        }
        public IEnumerable<Batch> SearchLotes(string parametro)
        {

            return dbConn.Query<Batch>(Queries.searchLotesBydescription, new { lote = "%" + parametro + "%" }).ToList();
        }

        public object GetBatchProductAvailable(int pBatchID)
        {
            return dbConn.Query<object>(Queries.batchProductAvailable, new
            {
                batchID = pBatchID
            }).FirstOrDefault();
        }


        public IEnumerable<Batch> getBatch()
        {
            return dbConn.Query<Batch>(Queries.selectAllbatch).ToList();


        }
        public bool bajalote(Batch bajal, IDbTransaction transaccion)
        {
            return dbConn.Execute(Queries.bajalote, new
            {
                active = bajal.Activo,
                id = bajal.LoteID

            }, transaccion) > 0;
        }
    }
}

 



