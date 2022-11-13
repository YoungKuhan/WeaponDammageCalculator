using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponDammageCalculator
{
    class ArrowDamage : WeaponDamage
    {
        private const decimal BASE_DAMAGE = 0.35M;
        private const decimal FLAME_DAMAGE = 2.5M;
        private const decimal MAGIC_DAMAGE = 1.25M;

        public ArrowDamage(int roll) : base(roll) { }

        protected override void CalculateDamage()
        {
            decimal baseDamage = Roll * BASE_DAMAGE;
            if (Magic) baseDamage *= MAGIC_DAMAGE;
            if (Flaming) baseDamage *= FLAME_DAMAGE;
            Damage = (int)Math.Ceiling(baseDamage);
        }
    }
}
