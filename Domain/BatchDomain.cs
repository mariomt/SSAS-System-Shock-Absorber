using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Domain
{
    public class BatchDomain
    {
        public bool insertBatch(ref Batch batch)
        {
            bool result = false;
            using( BatchDAO batchDao = new BatchDAO())
            {
                using (var connection = batchDao.Connection)
                {
                    connection.Open();
                    var transaction = connection.BeginTransaction();
                    try
                    {
                        result = new ProductDAO(connection).updateDisponibilidad(batch.ProductoID, batch.Cantidad, transaction);
                        if (result)
                        {
                            if (batchDao.insertBatch(batch,transaction))
                            {
                                transaction.Commit();
                                result = true;
                            }
                            else
                                throw new Exception("Error al guardar el lote de producto.");
                        }
                        else
                        {
                            throw new Exception("Error al actualizar la disponibilidad.");
                        }
                    }
                    catch (SqlException)
                    {
                        transaction.Rollback();
                        result = false;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return result;

        }

        public string validateFormInsertBatch(int ProductID,string Importe,string cantidad)
        {
            if (ProductID < 0)
            {
                return "Seleccione un producto";
            }

            Regex importeRegEx = new Regex(@"^[\d.]*$");
            var importeMatch = importeRegEx.Match(Importe);
            if (!importeMatch.Success)
            {
                return "El campo 'Importe' solo acepta números decimales";
            }

            Regex cantidadRegEx = new Regex(@"^[\d]*$");
            var cantidadMatch = cantidadRegEx.Match(cantidad);
            if (!cantidadMatch.Success)
            {
                return "El campo 'Cantidad' solo acepta números";
            }
            return "";
        }
    }
}
