namespace Monster
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var player = new Player("Ahmad", 31, "12345678");
            Console.WriteLine("please inter you password to play");
            string password = Console.ReadLine();
            if (password == player.Password)
            {
                var monster = new Monster(100);
                var weapon = new Weapon(30);
                weapon.Attack(monster);
                weapon.Attack(monster);
                weapon.Attack(monster);
                weapon.Attack(monster);


            }
            else
            {
                Console.WriteLine("Wrong password");
            }

        }
    }
}
