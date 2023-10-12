using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tales_of_demon_realm
{
    class EnemyPresets
    {
        public static Enemy smallGoblin;
        public static Enemy mediumGoblin;
        public static Enemy lackOfIdeas;

        public EnemyPresets() {
            smallGoblin = new Enemy("smallGoblin", 20, 3, 8, 0);
            smallGoblin.AddAbility(AbilitiesLibrary.enemyWeakAttack);
            smallGoblin.AddAbility(AbilitiesLibrary.enemyNormalAttack);
            smallGoblin.AddAbility(AbilitiesLibrary.enemyWeirdAttack);
            smallGoblin.AddAbility(AbilitiesLibrary.enemyWeakDefense);

            mediumGoblin = new Enemy("mediumGoblin", 80, 11, 16, 1);
            mediumGoblin.AddAbility(AbilitiesLibrary.enemyNormalAttack);
            mediumGoblin.AddAbility(AbilitiesLibrary.enemyWeirdAttack);

            lackOfIdeas = new Enemy("lackOfIdeas", 20, 6, 6, 0);
            lackOfIdeas.AddAbility(AbilitiesLibrary.enemyWeakAttack);
            lackOfIdeas.AddAbility(AbilitiesLibrary.enemyWeirdAttack);
        }
    }
}
