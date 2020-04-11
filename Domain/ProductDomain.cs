using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
<<<<<<< HEAD
using DataAccess;

namespace Domain
{
    public class ProductDomain
    {
        public void insertNewProduct(ref Product product)
        {
            new ProductDAO().insertProduct(product);
=======

namespace Domain
{
     public class ProductDomain
    {
        public IEnumerable<Product> getProducts()
        {
            Product producto1 = new Product();
            producto1.ProductoID = 1;
            producto1.Descripcion = "Tornillo";
            producto1.PrecioVenta = 55.5;
            producto1.IVA = 16;          
            producto1.Activo = true;

            List<Product> products = new List<Product>();
            products.Add(producto1);
            IEnumerable<Product> lista = products;
            return lista;


>>>>>>> 193f4843febe3d89dcf6e5dccf055f3e4379c010
        }
    }
}
