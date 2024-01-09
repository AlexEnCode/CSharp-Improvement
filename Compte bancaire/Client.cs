using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte_bancaire
{
    internal class Client
    {
        private static int _counter = 0;

        private string _nom;
        private string _prenom;
        private int _id;
        private string _numTelephone;
        private List<CompteBancaire> _comptes;

        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public string NumTelephone { get => _numTelephone; set => _numTelephone = value; }
        public int Id { get => _id; set => _id = value; }
        internal List<CompteBancaire> Comptes { get => _comptes; set => _comptes = value; }

        public Client(string nom, string prenom, string numTelephone )
        {
            _nom = nom;
            _prenom = prenom;
            _id = ++ _counter;
            _numTelephone = numTelephone;

            _comptes = new List<CompteBancaire>();
        }

    }
}