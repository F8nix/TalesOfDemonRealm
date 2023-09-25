using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tales_of_demon_realm
{
    class EnemyAbility
    {
        public string name;
        //public string quoteLibraryLink;
        public int weight;
        //public int repeats;
        //public int targettingType
        //punlic int range
        public Dictionary<string, float> affectedEnemyStats = new Dictionary<string, float>();
        public EnemyAbility(string enemyAbilityName, int enemyAbilityWeight) {
            name = enemyAbilityName;
            weight = enemyAbilityWeight;
        }

        public void AddStat(string statName, float statMultiplier) {
            affectedEnemyStats.Add(statName, statMultiplier);
        }
    }
}
