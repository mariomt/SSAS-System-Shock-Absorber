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
    public class ServiceDAO : DataAccessObjectBase
    {
        #region Constructores
        public ServiceDAO(IDbConnection pCon)
            : base(pCon)
        {

        }
        public ServiceDAO()
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

        public Service GetServiceById(int id, IDbTransaction pTransaction = null)
        {
            return dbConn.QueryFirstOrDefault<Service>(Queries.selectServiceById, new { 
                servicioID = id
            });
        }

        public bool insertNewService(Service pService)
        {
            var result = dbConn.Execute(Queries.insertService, new
            {
                name = pService.Nombre,
                description = pService.Descripcion,
                active = pService.Activo
            });

            return result > 0;
        }

        public bool UpdateService(Service pService)
        {
            return dbConn.Execute(Queries.updateService, new
            {
                name= pService.Nombre,
                desc = pService.Descripcion,
                active = pService.Activo,
                IdService = pService.ServicioID
            }) > 0;
        }
        public IEnumerable<Service> GetAll()
        {
            return dbConn.Query<Service>(Queries.selectAllServices).ToList();
        }

        public IEnumerable<Service> searchsByName(string filter)
        {
            return dbConn.Query<Service>(Queries.selectServicesByName, new
            {
                service= "%"+filter+"%"
            });
        }


        public bool disableService(Service pService, IDbTransaction pTransaction = null)
        {
            return dbConn.Execute(Queries.disablService, new
            {
                id = pService.ServicioID,
                active = pService.Activo
            },pTransaction) > 0 ;
        }
    }
}
