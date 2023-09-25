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
        //public string abilitiesQuoteLibraryLink;
        public int weight;
        //public int repeats;
        //public int targettingType
        //punlic int range
        //public bool isDelayed
        //public bool isBuff
        public Dictionary<string, float> affectedEnemyStats = new Dictionary<string, float>();
        public EnemyAbility(string enemyAbilityName, int enemyAbilityWeight) {
            name = enemyAbilityName;
            weight = enemyAbilityWeight;
        }

        public void AddStat(string statName, float statMultiplier) {
            affectedEnemyStats.Add(statName, statMultiplier);
        }

        public float GetStatMultiplier(string statName) {
            float statMultiplier = 0;
            affectedEnemyStats.TryGetValue(statName, out statMultiplier);
            return statMultiplier;
        }
    }
}
