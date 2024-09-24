using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster
{
    internal class GetPlayerDetails
    {

        public void GetPlayerName(Player player)
        {
            Console.WriteLine(player.Name);
        }
        public void GetPlayerAge(Player player)
        {
            Console.WriteLine(player.Age);
        }
        public void GetPlayerPassword(Player player)
        {
            Console.WriteLine(player.Password);
        }

    }
}
