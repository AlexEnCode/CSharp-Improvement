using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_salaire
{
    internal class Commercial
    {
        private double _ca;
        private double _commission;


        public double Ca { get => _ca; set => _ca = value; }
        public double Commission { get => _commission; set => _commission = value; }


        public Commercial(double ca, double commission)
        {
            Ca = ca;
            Commission = commission;
        }

    }
}
