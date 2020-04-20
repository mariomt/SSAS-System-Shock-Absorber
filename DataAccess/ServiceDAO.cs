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

        public bool insertNewService(Service service)
        {
            var result = dbConn.Execute(@"INSERT INTO Servicios(Nombre, Descripcion, Activo) VALUES(@name,@description,@active)", new
            {
                name = service.Nombre,
                description = service.Descripcion,
                active = service.Activo
            });

            return result > 0;
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
    }
}
