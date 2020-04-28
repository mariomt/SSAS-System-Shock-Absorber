using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess;
using System.Data.SqlClient;

namespace Domain
{
    public class ProductDomain
    {
        public void insertNewProduct(ref Product product)
        {
            new ProductDAO().insertProduct(product);

        }
        
        public IEnumerable<Product> getProducts()
        {
            
            return new ProductDAO().getProdcts();

        }

        public IEnumerable<Product> SearchProducts(string parametro)
        {
            return new ProductDAO().SearchProducts(parametro);
        }

        public bool bajaproducto(Product producto, BitacoraOperaciones motivo)
        {
            bool result = false;
            using(ProductDAO productoDAO = new ProductDAO())
            {
                using (var connection = productoDAO.Connection)
                {
                    connection.Open();
                    var transaction = connection.BeginTransaction();
                    try
                    {
                        result = new BitacoraOperacionesDAO(connection).Save(motivo, transaction);
                        if (result) 
                        {
                            result = productoDAO.bajaproducto(producto, transaction);


                            if (result)
                                transaction.Commit();
                            else
                                transaction.Rollback();

                        }
                        else
                        {
                            transaction.Rollback();
                        }

                    }
                    catch(SqlException var)
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
    }
}
