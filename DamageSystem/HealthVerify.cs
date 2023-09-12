using DamageSystem.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageSystem
{
    class HealthVerify
    {
        public static void VerifyHealthHero(Hero jooHero)
        {
            if(jooHero.Health <= 0)
            {
                Console.WriteLine("\nYou are Dead!");
                return;
            }
            else { return;}
        }
        public static void VerifyHealthEnemy(Enemy demon)
        {
            if (demon.HealthEnemy <= 0)
            {
                Console.WriteLine("\nYou defeated the enemy!");
                return;
            }
            else { return;}
        }
    }
}
