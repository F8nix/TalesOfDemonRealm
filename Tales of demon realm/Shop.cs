using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tales_of_demon_realm {
    class Shop {
        static double armorMod;
        static double weaponMod;

        public static void LoadShop(Player p) {
            armorMod = p.armorValue;
            weaponMod = p.weaponMaxValue;
            Console.Clear();
            RunShop(p);
        }

        public static void RunShop(Player p) {
            
            while (true) {
                double potionP = 20;
                double armorP = 100 * p.armorValue;
                double weaponP = 100 * (p.weaponMinValue + 1);
                Console.Clear();
                Console.WriteLine("            ______");
                Console.WriteLine("           | Shop |");
                Console.WriteLine("#=------------+#+------------=#");
                Console.WriteLine("|    (P)otions                |");
                Console.WriteLine("|    (W)eapons                |");
                Console.WriteLine("|    (A)rmors                 |");
                Console.WriteLine("|    (E)xit                   |");
                Console.WriteLine("#=------------+#+------------=#");
                Console.WriteLine("Pot " + potionP + "$ Weapon " + weaponP + "$ Armor " + armorP + "$");
                Console.WriteLine("           ________");
                Console.WriteLine("          | Player |");
                Console.WriteLine("#=------------+#+------------=#");
                Console.WriteLine("|    Current health: " + p.health);
                Console.WriteLine("|    Coins: " + p.coins);
                Console.WriteLine("|    Weapon strength: " + p.weaponMinValue + " - " + p.weaponMaxValue);
                Console.WriteLine("|    Armor toughness: " + p.armorValue);
                Console.WriteLine("|    Potions: " + p.potion);
                Console.WriteLine("#=------------+#+------------=#");
                string input = Console.ReadLine().ToLower();
                if (input == "p" || input == "potion") {
                    TryBuy("potion", potionP, p);
                }
                else if (input == "w" || input == "weapon") {
                    TryBuy("weapon", weaponP, p);
                }
                else if (input == "a" || input == "armor") {
                    TryBuy("armor", armorP, p);
                }
                else if (input == "e" || input == "exit")
                    break;
                else if (input == "q" || input == "quit") {
                    Program.Quit();
                }
            }
        }

        static void TryBuy(string item, double cost, Player p) {
            if (p.coins >= cost) {
                if (item == "potion") {
                    p.potion++;
                }
                else if (item == "weapon") {
                    p.weaponMinValue++;
                    p.weaponMaxValue++;
                }
                else if (item == "armor") {
                    p.armorValue++;
                }
                p.coins -= cost;
            }
            else {
                Console.WriteLine("You don't have enough coins.");
                Console.ReadKey();
            }
        }
    }
}