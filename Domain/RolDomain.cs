using DataAccess;
using Entities;
using System.Collections.Generic;

namespace Domain
{
    public class RolDomain
    {
        public IEnumerable<Rol> getAll()
        {
            return new RolDAO().getAll();
        }
    }
}
