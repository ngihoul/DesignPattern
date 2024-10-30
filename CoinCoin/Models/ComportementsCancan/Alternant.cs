using CoinCoin.Models.ComportementsCancan.Interfaces;
using System;
namespace CoinCoin.Models.ComportementsCancan
{
    internal class Alternant : IComportementCancan
    {
        private List<IComportementCancan> _Alternatives;
        private int _Index;

        public Alternant(List<IComportementCancan> alternatives)
        {
            _Alternatives = alternatives;
            _Index = 0;
        }

        public string Cancaner()
        {
            _Index = _Index >= _Alternatives.Count() ? 0 : _Index;

            string cancan = _Alternatives[_Index].Cancaner();

            _Index++;

            return cancan;
        }
    }
}
