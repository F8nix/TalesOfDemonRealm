using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tales_of_demon_realm
{
    class AbilitiesLibrary
    {
        public static Ability enemyWeakAttack = new Ability("enemyWeakAttack", AbilityType.Offensive, AbilitySource.Enemy, 100);
        public static Ability enemyNormalAttack = new Ability("enemyNormalAttack", AbilityType.Offensive, AbilitySource.Enemy, 400);
        public static Ability enemyWeirdAttack = new Ability("enemyWeirdAttack", AbilityType.Offensive, AbilitySource.Enemy, 300);
        public static Ability enemyWeakDefense = new Ability("enemyWeakDefense", AbilityType.Defensive, AbilitySource.Enemy, 500);
        //chyba tu tez trzeba dodac, co dany ability affektuje
        public AbilitiesLibrary() {
            enemyWeakAttack.affectedEnemyStatsMultipliers.Add(Stats.Health, 0.8f);
            enemyNormalAttack.affectedEnemyStatsMultipliers.Add(Stats.Health, 1f);
            enemyWeirdAttack.affectedEnemyStatsMultipliers.Add(Stats.Health, 1f);
            enemyWeakDefense.affectedEnemyStatsMultipliers.Add(Stats.Armor, 1f);
        }
    }
}
