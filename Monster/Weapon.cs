using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster
{
    internal class Weapon
    {
        public int Damage { get; set; }

        public Weapon(int damage)
        {
            this.Damage = damage;
        }

        public void Attack(Monster monster)
        {
            monster.TakeDamage(Damage) ;
        }
    }   
}
