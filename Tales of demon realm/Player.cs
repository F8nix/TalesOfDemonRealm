using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tales_of_demon_realm {
    [Serializable]
    class Player {
        public string name;
        public int id;
        public double coins = 10000;
        public double health = 10;
        public double damage = 1;
        public double armorValue = 0;
        public int potion = 5;
        public double weaponMinValue = 1;
        public double weaponMaxValue = 3;
    }
}
