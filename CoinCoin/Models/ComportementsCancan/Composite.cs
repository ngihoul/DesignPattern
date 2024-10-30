

using CoinCoin.Models.ComportementsCancan;
using CoinCoin.Models.ComportementsCancan.Interfaces;

namespace SuperCanard
{

    internal class TestComposite
    {
        public static IComportementCancan buildCri()
        {
            IComportementCancan result;
            IComportementCancan coinMuet = new Alternant(new List<IComportementCancan> { new Coincoin(), new Muet() });
            IComportementCancan begCoinMuet = new Begayeur(coinMuet);
            IComportementCancan begCoin = new Begayeur(new Coincoin());
            IComportementCancan canbegCoin = new Alternant(new List<IComportementCancan> { new Cancan(), begCoin });
            result = new Alternant(new List<IComportementCancan> { begCoinMuet, canbegCoin });
            return result;
        }

        public static IComportementCancan buildCri2()
        {
            // 2 Nodes with Muet
            /*IComportementCancan coinMuet = new Begayeur(new Alternant(new List<IComportementCancan> { new Coincoin(), new Muet() }));
            IComportementCancan canMuet = new Begayeur(new Alternant(new List<IComportementCancan> { new Cancan(), new Muet() }));

            IComportementCancan result = new Begayeur(new Alternant(new List<IComportementCancan> { coinMuet, canMuet }));*/

            // 1 Node with Muet
            IComportementCancan CoinOrCan = new Alternant(new List<IComportementCancan> { new Coincoin(), new Cancan() });
            IComportementCancan CoinAndCanOrMut = new Alternant(new List<IComportementCancan> { CoinOrCan, new Muet() });

            IComportementCancan CoinOrCanMuet = new Begayeur(CoinAndCanOrMut);

            IComportementCancan CoinMuetCanMuet = new Begayeur(CoinOrCanMuet);

            return CoinMuetCanMuet;

        }
    }
}
