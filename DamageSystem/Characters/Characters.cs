using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageSystem.Characters
{
    class Enemy
    {
        private double Enemydamage;
        private double Enemyhealth;
        public double DamageEnemy { get { return Enemydamage; } set { Enemydamage = value; } }
        public double HealthEnemy { get { return Enemyhealth; } set { Enemyhealth = value; } }

        public void EnemyAttack(Hero jooHero)
        {
            jooHero.Health -= DamageEnemy;
        }
    }

    class Hero : Enemy
    {
        private double damage;
        private double health;
        public double Damage { get { return damage; } set { damage = value; } }
        public double Health { get { return health; } set { health = value; } }

        public void HeroAttack(Enemy demon)
        {
            demon.HealthEnemy -= Damage;
        }
    }
}
