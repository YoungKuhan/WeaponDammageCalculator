using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponDammageCalculator
{
    class WeaponDamage
    {
        public int Damage { get; protected set; }
        private int roll;
        public int Roll {
            get { return roll; } 
            set
            {
                roll = value;
                CalculateDamage();
            } 
        }
        private bool flaming;
        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }
        private bool magic;
        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }
        protected virtual void CalculateDamage() { /*...*/}
        public WeaponDamage(int roll)
        {
            this.roll = roll;
            CalculateDamage();
        }
    }
}
