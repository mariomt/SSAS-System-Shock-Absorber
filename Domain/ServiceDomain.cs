using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
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
    }
}
