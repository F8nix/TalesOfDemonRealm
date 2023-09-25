using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tales_of_demon_realm
{
    class EnemiesOffenciveAbilities
    {
        public EnemyAbility normalAttack;
        public EnemyAbility weakAttack;
        public EnemyAbility strongAttack;
        public Dictionary<string, int> abilitiesWeights = new Dictionary<string, int>();
        public Dictionary<int, string> abilitiesNames = new Dictionary<int, string>();

        public EnemiesOffenciveAbilities()
        {
            normalAttack = new EnemyAbility("normalAttack", 700);
            weakAttack = new EnemyAbility("weakAttack", 400);
            strongAttack = new EnemyAbility("strongAttack", 100);
            //fajnie by bylo zeby wagi byly unikalne

            abilitiesWeights.Add(normalAttack.name, normalAttack.weight);
            abilitiesWeights.Add(weakAttack.name, weakAttack.weight);
            abilitiesWeights.Add(strongAttack.name, strongAttack.weight);

            abilitiesNames.Add(normalAttack.weight, normalAttack.name);
            abilitiesNames.Add(weakAttack.weight, weakAttack.name);
            abilitiesNames.Add(strongAttack.weight, strongAttack.name);

            //warto by bylo gdzies miec enuma czy cos typow statow
            normalAttack.AddStat("attack", 1.0f);
            weakAttack.AddStat("attack", 0.5f);
            strongAttack.AddStat("attack", 2.0f);
        }

        public void GetStatMultiplier(EnemyAbility enemyAbilityName, string enemyAbilityString, float multiplier) {
            enemyAbilityName.affectedEnemyStats.TryGetValue(enemyAbilityString, out multiplier);
        }
    }
}
