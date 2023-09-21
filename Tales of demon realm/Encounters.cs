using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tales_of_demon_realm {
    class Encounters {
        static Random rand = new Random();

        //Encounter generic

        //Encounters
        public static void FirstEncounter() {
            Console.WriteLine("You throw open the door and grab a rusty metal sword while charging towards your captor");
            Console.WriteLine("He turns...");
            Console.ReadKey();
            Combat(false, "Human Rogue", 1 , 4, 10 ,50);
        }

        public static void SecondEncounter() {
            Console.WriteLine("You throw open the door and grab a rusty metal sword while charging towards your captor");
            Console.WriteLine("He turns...");
            Console.ReadKey();
            Combat(false, "Human Rogue", 5, 100, 10, 50);
        }

        //Encounter tools

        public static void Combat(bool random, string name, double power, double health, double currencyMin, double currencyMax) {

            string n = "";
            double p = 0;
            double h = 0;
            double cMin = 0;
            double cMax = 0;
            
            if (random) {

            }
            else {
                n = name;
                p = power;
                h = health;
                cMin = currencyMin;
                cMax = currencyMax;
            }
            while (h > 0) {
                Console.Clear();
                Console.WriteLine(n);
                Console.WriteLine(p + "/" + h);
                Console.WriteLine("#=------------+#+------------=#");
                Console.WriteLine("|    (A)ttack     (D)efend    |");
                Console.WriteLine("|    (R)un        (H)eal      |");
                Console.WriteLine("#=------------+#+------------=#");
                Console.WriteLine("    Potions: " + Program.currentPlayer.potion + "     Health: " + Program.currentPlayer.health);
                string input = Console.ReadLine();

                //Attack
                if (input.ToLower() == "a" || input.ToLower() == "attack") {
                    Console.WriteLine("With haste you surge forth, your sword flying in your hands! As you pass, the "+n+" strikes you back as you pass.");
                    double attack = rand.Next((int)Program.currentPlayer.weaponMinValue, (int) (Program.currentPlayer.weaponMaxValue + 1));

                    if (attack < h) {
                        double damage = p - Program.currentPlayer.armorValue;
                        if (damage < 0) damage = 0;
                        Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage.");
                        Program.currentPlayer.health -= damage;
                    }
                    else {
                        Console.WriteLine("You deal final strike with " + attack + " damage.");
                    }
                    h -= attack;
                }
                //Defend
                else if (input.ToLower() == "d" || input.ToLower() == "defend") {
                    Console.WriteLine("As the " + n + "prepares to strike, your ready your sword in a defensive stance.");
                    double damage = Math.Floor(p / 4) - Program.currentPlayer.armorValue;
                    if (damage < 0) damage = 0;

                    Console.WriteLine("You lose " + damage + " health.");
                    Program.currentPlayer.health -= damage;
                }
                //Run
                else if (input.ToLower() == "r" || input.ToLower() == "run") {
                    if (rand.Next(0, 2) == 0) {
                        Console.WriteLine("As you spring away from the " + n + ", its strike catches you in the back, sprawling you in the back");
                        double damage = p - Program.currentPlayer.armorValue;
                        if (damage < 0) damage = 0;
                        Console.WriteLine("You lose " + damage + " health and you are unable to escape.");
                        Program.currentPlayer.health -= damage;
                    }
                    else {
                        Console.WriteLine("You succefully escape without harm!");
                        Console.ReadKey();
                        Shop.LoadShop(Program.currentPlayer);
                    }

                }
                //Heal
                else if (input.ToLower() == "h" || input.ToLower() == "heal") {
                    if (Program.currentPlayer.potion == 0) {
                        Console.WriteLine("As you try to grab a potion, you realise that you don't have this one.");
                        double damage = p - Program.currentPlayer.armorValue;
                        if (damage < 0) damage = 0;
                        Console.WriteLine("The " + n + " strikes you with a mighty blow and you lose " + damage + "health.");
                    }
                    else {
                        Console.WriteLine("You reach into your bag and pull out a red flask. You take a drink.");
                        int smallHealthPotionV = 5;
                        Console.WriteLine("You gain " + smallHealthPotionV + " health");
                        Program.currentPlayer.health += smallHealthPotionV;
                        double damage = p - Program.currentPlayer.armorValue;
                        if (damage < 0) damage = 0;
                        Console.WriteLine("The " + n + " strikes you with a mighty blow and you lose " + damage + " health.");
                        Program.currentPlayer.health -= damage;
                        Program.currentPlayer.potion -= 1;
                    }
                }
                if (Program.currentPlayer.health <= 0) {
                    Console.WriteLine("Git gud");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
                Console.ReadKey();
            }
            int c = rand.Next((int) cMin,(int) (cMax + 1));
            Console.WriteLine("After a fight you realise, that enemy body transformed into red falshing bulbs. As you try to touch them, they");
            Console.WriteLine("reach into you. You don't know why or how, but you KNOW that they are worth "+ c + " of... something.");
            Program.currentPlayer.coins += c;
            Console.ReadKey();
            Shop.LoadShop(Program.currentPlayer);
        }
    }
}
