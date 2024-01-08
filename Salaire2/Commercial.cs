using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salaire2;

namespace Salaire2
{
    internal class Commercial : Salarie
    {
        private double _ca;
        private double _commission;


        public double Ca { get => _ca; set => _ca = value; }
        public double Commission { get => _commission; set => _commission = value; }


        public Commercial(double ca, double commission, string matricule, string nom, string service, string categorie, decimal salaire ) : base(matricule, nom, service, categorie, salaire)
        {
            Ca = ca;
            Commission = commission;
        }

    }
}
