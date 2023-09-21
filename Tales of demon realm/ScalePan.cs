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
        public ScalePan(string name) {
            Name = name;
        }

        public int ScaleWeights(List<int> weightsList, int randomWeight, string name) {

            if (Name == name)
            {
                int listCount = weightsList.Count;
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
                        return weightsList.First();
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
    }
}
