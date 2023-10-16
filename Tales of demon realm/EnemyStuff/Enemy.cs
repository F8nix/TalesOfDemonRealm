using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tales_of_demon_realm
{
    class Enemy
    //class Enemy : ITarget
    {
        public string name;
        //public string type;
        //public string deathQuoteLibraryLink;
        //public int lvl;
        public double health;
        public double maxHealth;
        public double minDmg;
        public double maxDmg;
        public double armor;
        //public int actions;
        public WeightedList<Ability> enemyAbilities = new WeightedList<Ability>();

        public Enemy(string enemyName, double enemyHealth, double enemyMaxHealth, double enemyMinDamage, double enemyMaxDamage, double enemyArmor) //jeden powinien uzywac drugiego
        {
            //enemiesOffenciveAbilities = new EnemiesOffenciveAbilities();
            name = enemyName;
            health = enemyHealth;
            maxHealth = enemyMaxHealth;
            minDmg = enemyMinDamage;
            maxDmg = enemyMaxDamage;
            armor = enemyArmor;
        }

        public Enemy(string enemyName, double enemyMaxHealth, double enemyMinDamage, double enemyMaxDamage, double enemyArmor) //ten tutaj
        {
            //enemiesOffenciveAbilities = new EnemiesOffenciveAbilities();
            name = enemyName;
            maxHealth = enemyMaxHealth;
            health = enemyMaxHealth;
            minDmg = enemyMinDamage;
            maxDmg = enemyMaxDamage;
            armor = enemyArmor;
        }

        public void HasDied()
        {
            //printStrings
        }

        public void AddAbility(Ability ability) {
            enemyAbilities.list.Add(ability);
        }

        public void AddAbilities(List<Ability> abilitiesList) {
            enemyAbilities.list.AddRange(abilitiesList);
        }


        public List<(int, Stats)> UseAbility(AbilityType abilityType) {
            List<(int, Stats)> affectedEnemyStatsList = new List<(int, Stats)>();
            foreach (var stat in enemyAbilities.ChooseRandom(abilityType).affectedEnemyStats){
                affectedEnemyStatsList.Add(enemyAbilities.ChooseRandom(abilityType).CalculateAbilityEffect(stat, this));
            }
            return affectedEnemyStatsList;
        }

        /*
        public List<(int, Stats)> GetTarget() {
            
        }
        */
    }
}
