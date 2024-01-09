using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte_bancaire
{
    internal class CompteEpargne : CompteBancaire
    {
        private float _tauxInterets;

        public float TauxInterets { get => _tauxInterets; }

        public CompteEpargne(Client client, float tauxInterets, decimal solde = 0m) : base(client, solde)
        {
            _tauxInterets = tauxInterets;
        }

        public override bool Depot(decimal value)
        {
            throw new NotImplementedException();
        }

        public override bool Retrait(decimal value)
        {
            throw new NotImplementedException();
        }

        public void Epargner()
        { _solde += decimal.Multiply(_solde, (decimal)_tauxInterets);
    }
}
