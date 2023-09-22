using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tales_of_demon_realm
{
    class ScalePan
    {
        public string Name;
        //public GlobalRngSeed seed;

        public ScalePan(string name) {
            Name = name;
        }

        public int ScaleWeights(List<int> weightsList, string name) {
            //seed = new GlobalRngSeed(101);
            int randomWeight = CalculateRandomWeight(weightsList, true, GlobalRngSeed.GetSeed());
            if (Name == name)
            {
                int listCount = weightsList.Count;
                List<int> weightsListCopy = weightsList; //how about iterator
                for (int i = 0; i < listCount;)
                {
                    randomWeight -= weightsList.First();
                    //Console.WriteLine(weightsList.First()+ " and " + weightsList.Count + " and " + i + " and " + randomWeight);
                    if (randomWeight > 0)
                    {
                        weightsList.Remove(weightsList.First());
                        i++;
                    }
                    else if (weightsList.Count > 0)
                    {
                        int first = weightsList.First(); //coraz mniej mi sie podoba brak iteratora XD
                        weightsList = weightsListCopy;
                        return first;
                    }
                    else {
                        i = listCount;
                    }
                }
                Console.WriteLine("Too big random weight for " + Name + " list");
                Console.ReadLine();
                return 1;
            }
            else {
                Console.WriteLine("Incorrect name for " + Name + " list");
                Console.ReadLine();
                return 2;
            }
        }

        public int CalculateRandomWeight(List<int> weightsList, bool isSeeded, int seed) {
            
            int randomWeight = 0;
            foreach (int weight in weightsList)
            {
                randomWeight += weight;
            }
            if (randomWeight == 0) {
                Console.WriteLine("weightsList was empty");
                Console.ReadLine();
            }
            if (isSeeded)
            {
                Random rnd = new Random(seed);
                return rnd.Next(0, randomWeight + 1);
            }
            else
            {
                Random rnd = new Random();
                return rnd.Next(0, randomWeight + 1);
            }
        }
    }
}
