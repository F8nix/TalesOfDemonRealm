using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tales_of_demon_realm
{
    public sealed class GlobalRNG
    {
        private static Random _rnd;
        private static int seed = 100;
        public static Random rnd {
            get {
                if(_rnd == null) _rnd = new Random(seed);
                return _rnd;
            }
        }
   }
}
