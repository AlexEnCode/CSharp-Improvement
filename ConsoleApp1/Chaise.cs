using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
// See httinternal class chaise
    public class Chaise
    {
        // Atributs 
        private int _pieds = 4;
        private string _matiere = "bois";
        private string _couleur = "bois";
        private double _poids;
        private bool _vole = false;

        //propriétés

        public int Pieds { get => _pieds; set => _pieds = value; }
        public string Matiere { get => _matiere; set => _matiere = value; }
        public string Couleur { get => _couleur; set => _couleur = value; }

        private double Poids
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
                    _poids = 10;
                }
                else
                {
                    _poids = value;
                }

            }
        }
        public bool Vole { get => _vole; set => _vole = value; }


        // Methode

        public void AfficherlesInfos()
        {
            Console.WriteLine("La chaise " + Matiere + " est de couleur " + Couleur + " en " + Matiere + " et de couleur " + Couleur + ".");
        }
        // Constructeur

        public Chaise() { }
        public Chaise(int pieds, string matiere, string couleur, double poids, bool vole)
        {
            Pieds = pieds;
            Matiere = matiere;
            Couleur = couleur;
            Poids = poids;
            Vole = vole;
        }

        public override string ToString()
        {
            return base.ToString()
            + $"{Vole}";
        }

    }
}