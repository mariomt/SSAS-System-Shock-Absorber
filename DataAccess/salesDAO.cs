

using Dapper;
using Entities;
using System;
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
        public bool insert(Sale pSale, IDbTransaction pTransaction = null)
        {
            bool result = false;
            bool isTransactionNull = pTransaction == null;
            try
            {
                if (isTransactionNull)
                {
                    if (dbConn.State == ConnectionState.Closed)
                        dbConn.Open();

                    pTransaction = dbConn.BeginTransaction();
                }

                var id = dbConn.QueryFirst<int>(Queries.insertNewSale, new
                {
                    usuario = pSale.usuario.UsuarioID,
                    impTotal = pSale.ImporteTotal
                }, pTransaction);

                if(id > 0)
                {
                    pSale.VentaID = id;
                    foreach (var desc in pSale.descripcion)
                    {
                        if(desc.ProductoID != 0)
                        {
                            result = dbConn.Execute(Queries.insertProductToSale, new
                            {
                                ventaID = id,
                                productoID = desc.ProductoID,
                                cantidad = desc.Cantidad,
                                precioUnitario = desc.PrecioUnitario
                            }, pTransaction) > 0;
                        } else if(desc.ServicioID != 0)
                        {
                            result = dbConn.Execute(Queries.insertServiceToSale, new
                            {
                                ventaID = id,
                                servicioID = desc.ServicioID,
                                cantidad = desc.Cantidad,
                                precioUnitario = desc.PrecioUnitario
                            }, pTransaction) > 0;
                        }
                        else
                        {
                            if(isTransactionNull)
                                pTransaction.Rollback();
                            throw new Exception("No puede haber una descripcion sin producto o servicio asignado");
                        }


                        if (!result)
                        {
                            if (isTransactionNull)
                                pTransaction.Rollback();
                            throw new Exception("Ocurrio un error al guardar la venta");
                        }
                    }

                    if (result && isTransactionNull)
                    {
                            pTransaction.Commit();
                    }
                }
                else
                {
                    if (isTransactionNull)
                        pTransaction.Rollback();

                    result = false;
                }

            }
            catch (SqlException e)
            {
                result = false;
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (isTransactionNull)
                    dbConn.Close();
            }

            return result;
        }
    }
}
