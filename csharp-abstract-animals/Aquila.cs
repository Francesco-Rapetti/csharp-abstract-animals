using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Aquila : Animale
    {
        public override void Mangia()
        {
            Console.WriteLine("Aquila mangia carne");
        }

        public override void Verso()
        {
            Console.WriteLine("Stridio");
        }
    }
}
