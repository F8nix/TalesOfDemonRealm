using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tales_of_demon_realm
{
    interface ITarget
    {
        void IsTargetted(List<(int, Stats)> effectsList);
    }
}
