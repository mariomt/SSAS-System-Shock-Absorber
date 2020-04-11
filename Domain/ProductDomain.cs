using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess;

namespace Domain
{
    public class ProductDomain
    {
        public void insertNewProduct(ref Product product)
        {
            new ProductDAO().insertProduct(product);
        }
    }
}
