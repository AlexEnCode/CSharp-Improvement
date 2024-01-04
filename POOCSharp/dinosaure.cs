using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01Classes
{
    internal class dinosaure
    {
        // Atributs 
        private int _age;
        private string _espece;
        private int _nbPatte;
        private double _poids;
        private bool _vole = false;

        //propriétés

        public int Age { get => _age; set => _age = value; }
        public string Espece { get => _espece; set => _espece = value; }
        public int NbPatte { get => _nbPatte; set => _nbPatte = value; }
        public double Poids
        {
            get
            {
                Console.WriteLine(value: "Poids récupéré :");
                return _poids;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine(value: "Poids par defaut :");
                    _poids = 100;
                }
                else
                {
                    _poids = value;
                }

            }
        }
        public bool Vole { get => _vole; set => _vole = value; }


        public string AgeEspece { get => $"{Age} {Espece}"; }

        public string RegimeAlimentaire { get; set; } = "Herbivore";

        public string Nom{ get; set; }
    }
}
