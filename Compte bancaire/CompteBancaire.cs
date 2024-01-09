using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte_bancaire
{
    internal abstract class CompteBancaire
    {
        protected decimal _solde;
        protected Client _client;
        protected List<Operation> _operations;

        public decimal Solde { get => _solde; }
        public Client Client { get => _client; }
        public List<Operation> Operations { get => _operations; }

        protected CompteBancaire(Client client)
        {
            _client = client;

            _solde = 0;
            _operations = new();
        }
        protected CompteBancaire(Client client, decimal soldeInitial) : this(client)
        {
            _solde = soldeInitial;
        }

        public abstract bool Depot(decimal value);

        public abstract bool Retrait(decimal value);

        public void AfficherOperationSolde()
        {
            if (_operations.Count > 0)
            {
                Console.WriteLine("\n=== Liste des Opérations ===");
                foreach (Operation o in _operations)
                {
                    Console.WriteLine(o);
                }
            }
            else
            {
                Console.WriteLine("Pas d'opération");

            }
            Console.WriteLine($"Solde du Compte: {_solde} €");

        }
    }
}
