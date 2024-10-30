using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Models
{
    internal class Colvert : ICanard
    {
        public string Afficher()
        {
            return "Je suis un Colvert";
        }
    }
}
