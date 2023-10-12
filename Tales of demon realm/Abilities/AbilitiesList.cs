using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tales_of_demon_realm
{
    class AbilitiesList<T> where T : IWeightable
    {
        public List<T> list;

        public AbilitiesList() {
            list = new List<T>();
        }

        public T ChooseRandomAbility(AbilityType abilityType)
        {
            //weighting process: which weight will be chosen basing on random; if not then wat failed
            int randomWeight = CalculateRandomWeight(false, abilityType);
            int currentWeight;

            for (int i = 0; i < list.Count() ; i++) {
                if (list.ElementAt(i).GetAbilityType() == abilityType)
                {
                    currentWeight = list.ElementAt(i).GetWeight();
                    randomWeight -= currentWeight;
                    if (randomWeight <= 0)
                    {
                        return list.ElementAt(i);//zwracac ability
                    }
                }
            }

            Console.WriteLine("Too big random weight for list");
            Console.ReadLine();
            return list.ElementAt(0);

            /*
            if (name == scalePanName)
            {

                //implementacja sprawdzania weighta

                Console.WriteLine("Too big random weight for " + name + " list");
                Console.ReadLine();
                return 1;
            }
            else
            {
                Console.WriteLine("Incorrect name for " + name + " list");
                Console.ReadLine();
                return 2;
            }
            */
        }

        public int CalculateRandomWeight(bool isSeeded, AbilityType abilityType)
        {
            int randomWeight = 0;
            foreach (IWeightable weight in list)
            {
                if (weight.GetAbilityType() == abilityType)
                {
                    randomWeight += weight.GetWeight();
                }
            }
            if (randomWeight == 0)
            {
                Console.WriteLine("weightsList was empty");
                Console.ReadLine();
            }
            if (isSeeded)
            {
                return GlobalRNG.rnd.Next(0, randomWeight + 1);
            }
            else
            {
                Random rnd = new Random();
                return rnd.Next(0, randomWeight + 1);
            }
        }
    }
}
