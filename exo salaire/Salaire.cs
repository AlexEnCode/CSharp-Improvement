using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_salaire
{
    public class Salarie
    {

         // Atributs 

    /*         private Guid _matricule;
            private string _service;
            private string _categorie
            private string _nom 
            private int _salaire 
    */

  private static int _nombreSalarie = 0;
        //propriétés

        
        public Guid Matricule { get ; set ; } = System.Guid.NewGuid();
        public string Service { get; set; } = "sans";
        public string Categorie { get; set; } = "sans";

        public string Nom { get; set; } = "John Doe";
        public int Salaire { get; set; } = 0;

        // propiété static est relative a la classe
        
      
        public static int NombreSalarie  => _nombreSalarie;

        public Salarie()
        {
            Salarie._nombreSalarie++;
        }

        // Methode

        public void AfficherSalaire()
        {
            Console.WriteLine("Le salaire de " + Nom + " est de " + Salaire + "Euros. Son matricule est : " + Matricule);
        }


        // Constructeur

                public Salarie(Guid matricule, string service, string categorie, string nom, int salaire) : this() // a revoir
        {
            Matricule = matricule;
            Service = service;
            Categorie = categorie;
            Nom = nom;
            Salaire = salaire;
        }
    }
}

  