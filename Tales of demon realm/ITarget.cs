using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tales_of_demon_realm
{
    interface ITarget
    {
        List<(int, Stats)> GetTarget();
        //List<List<(int, Stats)>> GetTargets();
    }
}
