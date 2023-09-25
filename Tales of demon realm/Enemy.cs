using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tales_of_demon_realm
{
    class Enemy
    {
        public static EnemiesOffenciveAbilities enemiesOffenciveAbilities;
        public static ScalePan abilitiesPan;
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
        public List<EnemyAbility> offensiveAbilities = new List<EnemyAbility>();
        public List<EnemyAbility> defensiveAbilities = new List<EnemyAbility>();
        public List<int> offensiveAbilitiesWeights = new List<int>();
        public List<int> defensiveAbilitiesWeights = new List<int>();

        public Enemy(string enemyName, double enemyHealth, double enemyMaxHealth, double enemyMinDamage, double enemyMaxDamage)
        {
            enemiesOffenciveAbilities = new EnemiesOffenciveAbilities();
            name = enemyName;
            health = enemyHealth;
            maxHealth = enemyMaxHealth;
            minDmg = enemyMinDamage;
            maxDmg = enemyMaxDamage;
            foreach (var weight in offensiveAbilities) //tu moze byc problemik
            {
                offensiveAbilitiesWeights.Add(weight.weight);
            }
        }

        public Enemy(string enemyName, double enemyMaxHealth, double enemyMinDamage, double enemyMaxDamage)
        {
            enemiesOffenciveAbilities = new EnemiesOffenciveAbilities();
            name = enemyName;
            maxHealth = enemyMaxHealth;
            health = enemyMaxHealth;
            minDmg = enemyMinDamage;
            maxDmg = enemyMaxDamage;
            foreach (var weight in offensiveAbilities) //lub tuu
            {
                offensiveAbilitiesWeights.Add(weight.weight);
            }
        }

        public void HasDied()
        {
            //printStrings
        }

        public void AddAbility(bool isOffensive, EnemyAbility enemyAbility)
        {
            if (isOffensive)
            {
                offensiveAbilities.Add(enemyAbility);
            }
            else
            {
                defensiveAbilities.Add(enemyAbility);
            }
        }
        public int CalculateAbilityEffect(bool isOffensive) {
            abilitiesPan = new ScalePan("abilitiesPan");
            int randomWeight;
            string abilityName;
            //string stat;
            
            if (isOffensive)
            {
                randomWeight = abilitiesPan.ScaleWeights(offensiveAbilitiesWeights, abilitiesPan.name);
                enemiesOffenciveAbilities.abilitiesNames.TryGetValue(randomWeight, out abilityName);
                EnemyAbility randomEnemyAbility = offensiveAbilities.Find(x => x.name.Contains(abilityName));
                //stat = "attack"; //powinno sie samo znajdowac ale mozg mi paruje XD; powinno tez cos to dawac i byc w tuplu ale zla kolejnosc
                return (DealsDamage(randomEnemyAbility));
            }
            else {
                return 0;
                //return (0, "noStat"); tuple by bylo dobre ale nie jest
            }
        }

        public int DealsDamage(EnemyAbility enemyAbilityName)
        {
            float statMultiplier = 0;
            statMultiplier = enemyAbilityName.GetStatMultiplier("Attack");
            double minDamage = minDmg * statMultiplier;
            double maxDamage = maxDmg * statMultiplier;
            return CalculateDamage(true, GlobalRngSeed.GetSeed(), minDamage, maxDamage);
        }

        public int CalculateDamage(bool isSeeded, int seed, double minDamage, double maxDamage)
        {
            //outputs random/seeded int for weighting process
            if (isSeeded)
            {
                Random rnd = new Random(seed);
                return rnd.Next((int)Math.Ceiling(minDamage), ((int)Math.Ceiling(maxDamage)) + 1);
            }
            else
            {
                Random rnd = new Random();
                return rnd.Next((int)Math.Ceiling(minDamage), ((int)Math.Ceiling(maxDamage)) + 1);
            }
        }
    }
}
