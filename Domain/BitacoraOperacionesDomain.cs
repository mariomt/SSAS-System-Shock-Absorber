using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class BitacoraOperacionesDomain
    {
        public bool Save(BitacoraOperaciones pBitacoraOp)
        {
            return new BitacoraOperacionesDAO().Save(pBitacoraOp);
        }
    }
}
