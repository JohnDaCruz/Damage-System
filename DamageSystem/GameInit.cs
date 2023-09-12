using System;
using System.Linq;
using System.Text;
using System.Threading;
using DamageSystem.Buffs;
using System.Threading.Tasks;
using DamageSystem.Characters;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            Console.WriteLine($"Has a enemy along the way");
            while (choice == 0)
            {
                Waiting.Wait();

                Console.WriteLine("\nSelect a option between 1 - 5");
                Console.Write("You selected: ");
                choice = int.Parse(Console.ReadLine());

                if (choice >= 1 && choice <= 5)
                {
                    RandomChoice.ChoiceHero(choice, jooHero, demon);

                    Waiting.Wait();

                    RandomChoice.ChoiceEnemyMachine(jooHero, demon);

                    //Waiting.Wait();

                    HealthVerify.VerifyHealthEnemy(demon);
                    HealthVerify.VerifyHealthHero(jooHero);
                }
                else if (choice == 0 )
                {
                    return;
                }
                else
                {
                    Console.WriteLine("O número não está no intervalo de 1 a 5.");
                    choice = 0;
                }
                choice = 0;
            }

        }
    }
}
