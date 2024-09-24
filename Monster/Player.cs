using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster
{
    internal class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                if (value.Length == 8)
                {
                    _password = value;
                }
                else
                {
                    throw new ArgumentException("Password must be exactly 8 characters long.");
                }
            }
        }
        public Player(string name,int age, string password)
        {
            this.Name = name;
            this.Age = age;
            this._password = password;
        }


    }
}
