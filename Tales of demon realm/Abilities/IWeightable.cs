using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tales_of_demon_realm
{
    interface IWeightable
    {
        int GetWeight();
        AbilityType GetAbilityType(); //wywalic stad i wrzucic do predicate
    }
}
