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
             private double _poids = 10;
             private double _capacite = 10;
             private double _niveau = 0;

       


        //propriétés
        public string Name { get; set; }
        public double Poids { get { return _poids; } set { flotte = flotte - _poids; _poids = value; } }
        public double Capacite { get { return _capacite; } set { flotte = flotte - _capacite; _capacite = value; } }
        public double Niveau { get { return _niveau; } set { flotte = flotte - _niveau; _niveau = value; } }



        // propiété static est relative a la classe

        public static double flotte { get; set; }

        // Methode

        public void AfficherCiterne()
    {
        Console.WriteLine("Le niveau de la citerne " + Name + " est de " + Niveau + " litres,  pour une capacité: " + Capacite+ ".");
    }
  

        public WaterTank(string name, double poids, double capacite, double niveau)
        {
            Name = name;
            Poids = poids;
            Capacite = capacite;
            Niveau = niveau;
           }

                // Constructeur




    }
}
  

