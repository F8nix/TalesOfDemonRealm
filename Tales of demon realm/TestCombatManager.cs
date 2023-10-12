using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tales_of_demon_realm
{
    class TestCombatManager
    {
        public static EnemyPresets enemyPresets;
        public static Enemy[] enemyPlaces;
        public int target = 200;
        public bool playerTurn = true;
        public TestCombatManager() {
            enemyPresets = new EnemyPresets();
            enemyPlaces = new Enemy[8];
            /*
            enemyPlaces[0] = enemyPresets.smallGoblin;
            enemyPlaces[1] = enemyPresets.mediumGoblin;
            enemyPlaces[2] = enemyPresets.lackOfIdeas;
            */
        }

        //oczywiscie jakies metody do wavow
        //logika przeciwnikom bedzie potrzebna, ale to w przeciwnikach raczej; chooociaz

        public void PrintOutTestCombat() {
            if (playerTurn)
            {
                Console.Clear();
                Console.WriteLine(enemyPlaces[0].name + " hp: " + enemyPlaces[0].health + " target hp: " + target);
                Console.WriteLine(enemyPlaces[1].name + " hp: " + enemyPlaces[1].health);
                Console.WriteLine(enemyPlaces[2].name + " hp: " + enemyPlaces[2].health);
                playerTurn = false;
            }

            //jak moglby for wygladac, tylko do srodka ifa sprawdzajacego jakos, czy jest czy nie ma przeciwnika i ofc czesc printowa dla gracza
            /*for (int i = 1; i < enemyPlaces.Length; i++) {
                Console.WriteLine(enemyPlaces[i].name + " hp: " + enemyPlaces[i].health);
            }*/
        }

        public void WaitForTurnInput() {
            //jakis madry while meczacy gracza, zeby klikal co trzeba
            string input;
            input = Console.ReadLine();
            if (input == "s" && !playerTurn) {
                /*
                target -= enemyPlaces[0].CalculateAbilityEffect(true);
                target -= enemyPlaces[1].CalculateAbilityEffect(true);
                target -= enemyPlaces[2].CalculateAbilityEffect(true);
                playerTurn = true;
                */
            }
        }

        public void AffectTarget() {
            
            //tu potem jakis madry for ktory kazdego przeciwnika bierze i pyta o umiejke
        }
    }
}
