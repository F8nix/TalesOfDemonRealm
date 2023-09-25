using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tales_of_demon_realm
{
    class EnemyPresets
    {
        public Enemy smallGoblin;
        public Enemy mediumGoblin;
        public Enemy lackOfIdeas;
        public static EnemiesOffenciveAbilities enemiesOffenciveAbilities;

        public EnemyPresets() {
            enemiesOffenciveAbilities = new EnemiesOffenciveAbilities();

            smallGoblin = new Enemy("smallGoblin", 20, 3, 8);
            smallGoblin.AddAbility(true, enemiesOffenciveAbilities.normalAttack);
            smallGoblin.AddAbility(true, enemiesOffenciveAbilities.weakAttack);
            smallGoblin.AddAbility(true, enemiesOffenciveAbilities.strongAttack);

            mediumGoblin = new Enemy("mediumGoblin", 80, 11, 16);
            mediumGoblin.AddAbility(true, enemiesOffenciveAbilities.normalAttack);
            mediumGoblin.AddAbility(true, enemiesOffenciveAbilities.strongAttack);

            lackOfIdeas = new Enemy("lackOfIdeas", 20, 6, 6);
            lackOfIdeas.AddAbility(true, enemiesOffenciveAbilities.weakAttack);
            lackOfIdeas.AddAbility(true, enemiesOffenciveAbilities.specialAttack);
        }
    }
}
