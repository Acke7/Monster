using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster
{
    internal class Monster
    {
        public int Hp { get; set; }
        public Monster(int hp)
        {
            this.Hp = hp;
        }

        public void TakeDamage(int damage)
        {
            Hp -=damage;
            Console.WriteLine("Monster hp is..."+Hp);
            if (Hp <=0 )
            {
                Dead();
            }
        }
        public void Dead()
        {
            Console.WriteLine( "Monster is dead");
        }
    }
}
