using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ServiceDomain
    {
        public bool insertNewProduct(Service service)
        {
            return new ServiceDAO().insertNewService(service);
        }
        public IEnumerable<Service> GetAll()
        {
            return new ServiceDAO().GetAll();
        }

        public IEnumerable<Service> SearchByName(string filter)
        {
            return new ServiceDAO().searchsByName(filter);
        }

        public bool disableService(Service pService, BitacoraOperaciones pBitacoraOp)
        {
            if(pBitacoraOp.Comentario.Trim().Length < 10)
                throw new ServiceDomainException("El comentario debe contener almenos 10 letras.");
         
            bool result = false;
            using (var service = new ServiceDAO())
            {
                using (var connection = service.Connection)
                {
                    connection.Open();
                    var transaction = connection.BeginTransaction();
                    try
                    {
                        result = new BitacoraOperacionesDAO(connection).Save(pBitacoraOp, transaction);
                        if (result)
                            result = service.disableService(pService, transaction);
                        if (result)
                            transaction.Commit();
                        else
                            transaction.Rollback();
                    } catch (SqlException)
                    {
                        transaction.Rollback();
                        result= false;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return result;
        }
    }
}

public class ServiceDomainException : Exception
{
    /// <summary>
    /// Crea una nueva excepcion generica de la clase ServiceDomain.
    /// </summary>
    public ServiceDomainException()
    {

    }
    /// <summary>
    /// Crea una nueva excepcion generica de la clase ServiceDomain, con un mensaje.
    /// </summary>
    /// <param name="message">Mensaje que describe el error.</param>
    public ServiceDomainException(string message) 
        : base(message)
    {
    }

    /// <summary>
    /// Crea una nueva excepcion generica de la clase ServiceDomain, con un mensaje y una excepción anidada.
    /// </summary>
    /// <param name="message">Mensaje que describe el error.</param>
    /// <param name="innerException">Excepción interna</param>
    public ServiceDomainException(string message, Exception innerException) 
        : base(message, innerException)
    {
    }
}
