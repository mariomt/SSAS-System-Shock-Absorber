using DataAccess;
using Entities;
using System;

namespace Domain
{
    public class saleDomain
    {

        public bool insert(Sale pSale)
        {

            bool result = false;
            try
            {
                getTotal(ref pSale);
                result = new salesDAO().insert(pSale);
            }catch(totalException e)
            {
                throw e;
            }

            return result;
        }

        public void getTotal(ref Sale pSale)
        {
            double total = 0;

            foreach( var desc in pSale.descripcion)
            {
                total += desc.Cantidad * desc.PrecioUnitario;
            }

            if (total == 0) throw new totalException("El total de la venta no debe ser cero");
            if (total < 0) throw new totalException("El total no debe ser negativo");

            pSale.ImporteTotal = total;
        }
    }

    public class totalException: Exception
    {
        public totalException(string message):
            base(message)
        {

        }
    }
}
