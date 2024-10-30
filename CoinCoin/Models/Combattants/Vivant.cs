using CoinCoin.Models.Combattants.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCoin.Models.Combattants
{
    public abstract class Vivant : IVivant
    {
        private int _vie;
        private int _force;
        private int _defence;

        public int Vie { get => _vie; internal set => _vie = Math.Max(0, value); }
        public int Force { get => _force; internal set => _force = Math.Max(0, value); }
        public int Defence { get => _defence; internal set => _defence = Math.Max(0, value); }

        public void AddDefence(int defence)
        {
            Defence += defence;
        }

        public void AddForce(int force)
        {
            Force += force;
        }

        public void AddVie(int vie)
        {
            Vie += vie;
        }

        public abstract IVivant Combattre(IVivant adversaire);
    }
}
