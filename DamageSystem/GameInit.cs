using System;
using System.Linq;
using System.Text;
using System.Threading;
using DamageSystem.Buffs;
using System.Threading.Tasks;
using DamageSystem.Characters;
using System.Collections.Generic;

namespace DamageSystem
{
    class GameInit
    {

        public void GameStart()
        {
            Hero jooHero = new()
            {
                Damage = 30,
                Health = 100
            };

            Enemy demon = new()
            {
                DamageEnemy = 42.5,
                HealthEnemy = 120
            };

            BuffandNerf buff = new();

            int choice = 0;
            while (choice == 0)
            {
                Console.WriteLine($"Has a enemy along the way");
                Waiting.Wait();

                Console.WriteLine("\nSelect a option between 1 - 5");
                Console.Write("You selected: ");
                choice = int.Parse(Console.ReadLine());

                RandomChoice.ChoiceHero(choice, jooHero, demon);

                Waiting.Wait();

                RandomChoice.ChoiceEnemyMachine(jooHero,demon);


                choice = 0;
            }

        }
    }
}
