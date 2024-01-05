using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citerne
{

    internal class WaterTank
    {

        // Atributs 
        private string _name = "Chateau d'Eau";
        private int _poids = 10;
        private int _capacite = 10;
        private int _niveau = 0;




        //propriétés
        public string Name { get; set; }
        public int Poids { get { return _poids; } set { flotte = flotte - _poids; _poids = value; } }
        public int Capacite { get { return _capacite; } set { flotte = flotte - _capacite; _capacite = value; } }
        public int Niveau { get { return _niveau; } set { flotte = flotte - _niveau; _niveau = value; } }



        // propiété static est relative a la classe

        public static double flotte { get; set; }

        // Methode

        public void AfficherCiterne()
        {
            Console.WriteLine("Le niveau de la citerne " + Name + " est de " + Niveau + " litres,  pour une capacité: " + Capacite + ".");
        }


        public void AffichageCiterne()
        {
            string[,] citerneAscii = {
                {"┌──────O─────┐",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "└────────────┘"},
                {"┌──────O─────┐",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│~~~~~~~~~~~~│",
                "└────────────┘"},
                {"┌──────O─────┐",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│~~~~~~~~~~~~│",
                "│            │",
                "└────────────┘"},
                {"┌──────O─────┐",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│~~~~~~~~~~~~│",
                "│            │",
                "│            │",
                "└────────────┘"},
                {"┌──────O─────┐",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│~~~~~~~~~~~~│",
                "│            │",
                "│            │",
                "│            │",
                "└────────────┘"},
                {"┌──────O─────┐",
                "│            │",
                "│            │",
                "│            │",
                "│~~~~~~~~~~~~│",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "└────────────┘"},
                {"┌──────O─────┐",
                "│            │",
                "│            │",
                "│~~~~~~~~~~~~│",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "└────────────┘"},
                {"┌──────O─────┐",
                "│            │",
                "│~~~~~~~~~~~~│",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "└────────────┘"},
                {"┌──────O─────┐",
                "│~~~~~~~~~~~~│",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "└────────────┘"},
            };
            int niveauCiterne = Niveau == 1 ? 1 : (Niveau * 8 / Capacite);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(citerneAscii[niveauCiterne, i]);
            }
        }




        // Constructeur
        public WaterTank(string name, int poids, int capacite, int niveau)
        {
            Name = name;
            Poids = poids;
            Capacite = capacite;
            Niveau = niveau;
        }
    }
}
