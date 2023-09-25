using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Tales_of_demon_realm {

    /*public Enum EnemiesOffenciveAbilitiesName
    {
        normalAttack = "normalAttack",
        weakAttack = "weakAttack",
        strongAttack = "strongAttack"
    }*/
    class Program {
        public static Player currentPlayer = new Player();
        public static ScalePan testPan;
        public static List<int> enemyOneOffList = new List<int>();

        public static EnemiesOffenciveAbilities enemiesOffenciveAbilities;
        


        public static int randomOutput1;
        public static int randomOutput2;
        static void Main(string[] args) {
            testPan = new ScalePan("testPan");
            enemiesOffenciveAbilities = new EnemiesOffenciveAbilities();
            enemyOneOffList.Add(enemiesOffenciveAbilities.normalAttack.weight);
            enemyOneOffList.Add(enemiesOffenciveAbilities.strongAttack.weight);
            enemyOneOffList.Add(enemiesOffenciveAbilities.weakAttack.weight);
            randomOutput1 = testPan.ScaleWeights(enemyOneOffList, testPan.name);
            randomOutput2 = testPan.ScaleWeights(enemyOneOffList, testPan.name);
            if (!Directory.Exists("saves")) {
                Directory.CreateDirectory("saves");
            }
            currentPlayer = Load(out bool newP);
            string temp1;
            string temp2;
            enemiesOffenciveAbilities.abilitiesNames.TryGetValue(randomOutput1, out temp1);
            enemiesOffenciveAbilities.abilitiesNames.TryGetValue(randomOutput2, out temp2);
            Console.WriteLine(temp1+ " i kolejna umiejka "+temp2+ " na podstawie wartosci " + randomOutput1 + " i " +randomOutput2);
            Console.ReadLine();
            if (newP)
            {
                Encounters.FirstEncounter();
            }
            Encounters.SecondEncounter();
            string data = Console.ReadLine();
        }

        static Player NewStart(int i) {
            Console.Clear();
            Player p = new Player();
            Console.WriteLine("Tales of demon realm");
            Console.WriteLine("Name:");
            p.name = Console.ReadLine();
            p.id = i;
            Console.Clear();
            Console.WriteLine("You awake in a cold, stone, dark room. You feel dazed and are having trouble remembering");
            Console.WriteLine("anything about your past.");
            if (p.name == "") Console.WriteLine("You can't even remember your own name...");
            else Console.WriteLine("At least you know your name is " + p.name);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You grope around in the darkness until you find a door handle. You feel some resistance as");
            Console.WriteLine("you utrun the handle, but the rusty lock breaks with little effort. You see your captor");
            Console.WriteLine("standing with his back to you outside the door.");
            return p;
        }

        public static void Quit() {
            Save();
            Environment.Exit(0);
        }

        public static void Save() {
            BinaryFormatter binForm = new BinaryFormatter();
            string path = "saves/" + currentPlayer.id.ToString() + ".level";
            FileStream file = File.Open(path, FileMode.OpenOrCreate);
            binForm.Serialize(file, currentPlayer);
            file.Close();
        }

        public static Player Load(out bool newP) {
            newP = false;

            Console.Clear();
            string[] paths = Directory.GetFiles("saves");
            List<Player> players = new List<Player>();
            int idCount = 0;

            BinaryFormatter binform = new BinaryFormatter();
            foreach (string p in paths) {
                FileStream file = File.Open(p, FileMode.Open);
                Player player = (Player)binform.Deserialize(file);
                file.Close();
                players.Add(player);
            }

            idCount = players.Count;

            while (true) {
                Console.Clear();
                Console.WriteLine("Choose your player:");

                foreach (Player p in players) {
                    Console.WriteLine(p.id + ": " + p.name);
                }

                Console.WriteLine("Please input player name or id (id:# or playername). Additionally, 'create' will start a new save");
                string[] data = Console.ReadLine().Split(":");
                try {
                    if (data[0] == "id") {
                        if (int.TryParse(data[1], out int id)) {
                            foreach (Player player in players) {
                                if (player.id == id) {
                                    return player;
                                }
                            }
                            Console.WriteLine("There is no player with that id!");
                            Console.ReadKey();
                        }
                        else {
                            Console.WriteLine("Your id needs to be a number! Press any key to continue!");
                            Console.ReadKey();
                        }
                    }
                    else if (data[0] == "create") {
                        Player newPlayer = NewStart(idCount);
                        newP = true;
                        return newPlayer;
                    }
                    else {
                        foreach (Player player in players) {
                            if (player.name == data[0]) {
                                return player;
                            }
                        }
                        Console.WriteLine("There is no player with that name!");
                        Console.ReadKey();
                    }
                }
                catch (IndexOutOfRangeException) {
                    Console.WriteLine("Your id needs to be a number! Press any key to continue!");
                    Console.ReadKey();
                }
            }
        }
    }
}
