using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Models
{
    public class Mandarin : ICanard
    {
        public string Afficher()
        {
            return "Je suis un Mandarin !";
        }
    }
}
