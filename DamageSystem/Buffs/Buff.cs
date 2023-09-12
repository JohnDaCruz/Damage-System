using DamageSystem.Characters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageSystem.Buffs
{
    class BuffandNerf
    {
        private double healthBuff = 30;
        private double damageBuff = 15;

        private double healthNerf = -30;
        private double damageNerf = -15;
        public double HealthBuff { get { return healthBuff; } private set { healthBuff = value; } }
        public double DamageBuff { get { return damageBuff; } private set { damageBuff = value; } }

        public double HealthNerf { get { return healthNerf; } private set { healthNerf = value; } }
        public double DamageNerf { get { return damageNerf; } private set { damageNerf = value; } }

        public void BuffHealthHero(Hero hero)
        {
            hero.Health += HealthBuff;
        }

        public void BuffDamageHero(Hero hero)
        {
            hero.Damage += DamageBuff;
        }

        public void NerfHealthHero(Hero hero)
        {
            hero.Health += HealthNerf;
        }

        public void NerfDamageHero(Hero hero)
        {
            hero.Damage += DamageNerf;
        }
    }
}
