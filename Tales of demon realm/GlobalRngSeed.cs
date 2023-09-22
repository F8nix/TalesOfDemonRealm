using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tales_of_demon_realm
{
    class GlobalRngSeed
    {
        public static int globalRngSeed = 100;
        public GlobalRngSeed(int optionalSeed) {
            globalRngSeed = optionalSeed;
        }

        public GlobalRngSeed() { }
        public static int GetSeed()
        {
            return globalRngSeed;
        }
    }
}
