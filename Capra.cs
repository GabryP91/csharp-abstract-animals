using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Capra : Animale
    {
        public override void Verso()
        {
            Console.WriteLine("Fascista! Fascista! Fascista!");
        }

        public override void Mangia()
        {
            Console.WriteLine("Erba");
        }
    }
}
