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
    public class ProductDomain
    {

        public Product GetProductById(int id)
        {
            return new ProductDAO().GetProductById(id);
        }

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

        /// <summary>
        /// Método para actualizar la información de un producto.
        /// </summary>
        /// <param name="pProduct"></param>
        /// <returns>Regresa true si se modificó almenos un registro, y false si no se modificó ningún registro</returns>
        public bool updateProduct(Product pProduct)
        {
            if (pProduct.ProductoID == 0)
                throw new Exception("El producto no contiene un identificador");

            return new ProductDAO().updateProduct(pProduct);
        }
        /// <summary>
        /// Método para validar los campos del formulario para ingresar o actualizar un producto
        /// </summary>
        /// <param name="Descripcion" ></param>
        /// <param name="IVA"></param>
        /// <param name="Disponibilidad"></param>
        /// <param name="PrecioVenta"></param>
        /// <returns>Regresa un mensaje de texto si un campo no cumple con el patrón especificado para cada parametro</returns>
        public string validateFormProduct(string Descripcion, string IVA, string Disponibilidad, string PrecioVenta)
        {

            Regex descripcionRegEx = new Regex(@"^[\w\s]*$"); //patrón de letras, números y space
            var descripcionMatch = descripcionRegEx.Match(Descripcion);
            if (!descripcionMatch.Success)
            {
                return "El campo 'Descripcion' solo acepta letras y números";
            }

            Regex IVARegEx = new Regex(@"^\d{1,}\.{1}\d{2}$"); //patrón de número con dos decimales despues del punto
            var IVAMatch = IVARegEx.Match(IVA.ToString());
            if (!IVAMatch.Success)
            {
                return "El campo 'IVA' solo acepta números con 2 decimales";
            }

            Regex DisponibilidadRegEx = new Regex(@"^\d{1,}$"); //patrón de número entero
            var DisponibilidadMatch = DisponibilidadRegEx.Match(Disponibilidad.ToString());
            if (!DisponibilidadMatch.Success)
            {
                return "El campo 'Disponibilidad' solo acepta números enteros";
            }

            Regex PrecioVentaRegEx = new Regex(@"^\d{1,}\.{1}\d{2}$"); //patrón de número con dos decimales despues del punto
            var PrecioVentaMatch = PrecioVentaRegEx.Match(PrecioVenta.ToString());
            if (!PrecioVentaMatch.Success)
            {
                return "El campo 'PrecioVenta' solo acepta números enteros";
            }

            return "";
        }

       
    }

}
