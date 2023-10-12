using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tales_of_demon_realm
{
    class Ability : IWeightable
    {
        public string name;
        public AbilityType abilityType;
        public AbilitySource abilitySource;
        //public string abilitiesQuoteLibraryLink;
        public int weight;
        //public int repeats;
        //public int targettingType //enum
        //punlic int range
        //public bool isDelayed
        //public bool isBuff
        public Dictionary<Stats, float> affectedEnemyStatsMultipliers = new Dictionary<Stats, float>();
        public List<Stats> affectedEnemyStats = new List<Stats>();

        public Ability(string abilityName, AbilityType abilityType, AbilitySource abilitySource, int abilityWeight) {
            name = abilityName;
            this.abilityType = abilityType;
            this.abilitySource = abilitySource;
            weight = abilityWeight;
        }

        public void AddStat(Stats statName, float statMultiplier) {
            affectedEnemyStatsMultipliers.Add(statName, statMultiplier);
            affectedEnemyStats.Add(statName);
        }

        public float GetStatMultiplier(Stats statName) {//moze sie nie przydac, na razie jest
            float statMultiplier = 0;
            affectedEnemyStatsMultipliers.TryGetValue(statName, out statMultiplier);
            return statMultiplier;
        }

        public (int, Stats) CalculateAbilityEffect(Stats calculatedStat, Enemy enemy) /*moze typ efektu czyli dmg, heal, armorUp; sile efektu*/
        {
            int effectPower = 0;
            int effectPowerMin = 0;
            int effectPowerMax = 0;
            switch (calculatedStat) {
                case Stats.Armor: {
                        effectPower = (int) (Math.Ceiling(enemy.armor * GetStatMultiplier(Stats.Armor)));
                        return (effectPower, Stats.Armor);
                    //break;
                }
                case Stats.Health: {
                        effectPowerMin = (int)(Math.Ceiling(enemy.minDmg * GetStatMultiplier(Stats.Health)));
                        effectPowerMax = (int)(Math.Ceiling(enemy.maxDmg * GetStatMultiplier(Stats.Health)));
                        effectPower = GlobalRNG.rnd.Next(effectPowerMin, effectPowerMax + 1);
                        return (-effectPower, Stats.Health);
                        //break;
                }
                default: {
                        Console.WriteLine("Improper stat inserted");
                        Console.ReadLine();
                        return (0, Stats.Health);
                        //break;
                }
            }
        }

        public int GetWeight() {
            return weight;
        }

        public AbilityType GetAbilityType() {
            return abilityType;
        }
    }
}
