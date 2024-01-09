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
        private decimal _ca;
        private decimal _comission;


        public decimal Ca { get => _ca; set => _ca = value; }
        public decimal Comission { get => _comission; set => _comission = value; }


        public Commercial( string matricule, string nom, string service, string categorie, decimal salaire, decimal ca, decimal comission) : base(matricule, nom, service, categorie, salaire)
        {
            Ca = ca;
            Comission = comission;
        }


    }
}
