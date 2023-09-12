using DamageSystem.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageSystem
{
    internal class RandomChoice
    {
        public static void ChoiceHero(int Choice, Hero jooHero, Enemy demon)
        {
            Random r = new Random();
            int aleatoryNumber = r.Next(5);

            if (aleatoryNumber == Choice)
            {
                Console.WriteLine("\n######################");

                Console.WriteLine($"Health Enemy -> {demon.HealthEnemy} ");
                Console.WriteLine("Is a critical!!");
                jooHero.HeroAttack(demon);
                Console.WriteLine($"Health Enemy -> {demon.HealthEnemy} ");

                Console.WriteLine("######################");
            }
            else
            {
                Console.WriteLine("\n######################");

                Console.WriteLine("You almost hit him :( ");

                Console.WriteLine("######################");
            }
            return;
        }

        public static void ChoiceEnemyMachine(Hero jooHero, Enemy demon)
        {
            Random r = new Random();
            int aleatoryNumber = r.Next(5);
            int aleatoryNumberMachine = r.Next(5);


            if (aleatoryNumber == aleatoryNumberMachine)
            {
                Console.WriteLine("\n######################");

                Console.WriteLine($"Your Health -> {jooHero.Health} ");
                Console.WriteLine("The Enemy hit a critical!!!");
                demon.EnemyAttack(jooHero);
                Console.WriteLine($"Your Health -> {jooHero.Health} ");

                Console.WriteLine("######################");
            }
            else
            {
                Console.WriteLine("\n######################");

                Console.WriteLine("He dont hit you!! :D ");

                Console.WriteLine("######################");
            }
            return;
        }
    }
}
