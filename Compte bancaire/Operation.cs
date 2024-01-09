using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte_bancaire
{
    internal class Operation
    {
        private static int _count = 0;

        private int _num;
        private decimal _montant;
        private TypeOperation _type;

        public int Num { get => _num; }
        public decimal Montant { get => _montant; }
        public TypeOperation Type { get => _type; }

        public Operation(decimal montant, TypeOperation type) : base()
        {
            _num = ++_count;
            _montant = montant;
            _type = type;
        }

        public override string ToString()
        {
            return $"{_num}. {Enum.GetName(_type)}";
        }
    }
}
