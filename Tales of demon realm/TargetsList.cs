using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tales_of_demon_realm
{
    class TargetsList<T> where T : ITarget
    {
        public List<T> list;

        public List<(int, Stats)> affectedStatsList;

        public TargetsList()
        {
            list = new List<T>();
        }

        public void AffectStat() {
            foreach (ITarget target in list)
            {
                affectedStatsList = target.GetTarget();
                foreach ((int, Stats) affectedStat in affectedStatsList)
                {
                    //T.affectedStat.Item2 += affectedStat.Item1;       myslalem, ze przejdzie
                }
            }
        }
    }
}
