using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte_bancaire
{
    internal class CompteCourant : CompteBancaire
    {
         public CompteCourant(Client client ,decimal solde = 0 ) : base(client ,solde)
        {
        }

        public override bool Depot(decimal value)
        {
            _operations.Add(new Operation(value, TypeOperation.DEPOT));
            _solde += value;
            return true;
        }

        public override bool Retrait(decimal value)
        {
            if(_solde > 0 ) return false;
            else _operations.Add(new Operation(value, TypeOperation.RETRAIT)); _solde -= value; return true;
        }
        
      

    }
}
