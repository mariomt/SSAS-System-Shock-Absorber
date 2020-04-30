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
        public void insertBatch(ref Batch batch)
        {
            new BatchDAO().insertBatch(batch);
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
