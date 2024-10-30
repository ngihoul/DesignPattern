using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCoin.Models.Canards.Interfaces
{
    public interface ICanard : ICancanVolant
    {
        public string Afficher();
        public string Nager();
    }
}
