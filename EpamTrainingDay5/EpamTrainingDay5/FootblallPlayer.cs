using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTrainingDay5
{
    class FootballPlayer
    {
        public string LastName { get; }

        public int Age { get; }

        public int Level { get; }

        
        public FootballPlayer(string lastName, int age)
        {
            this.LastName = lastName;
            this.Age = age;
            this.Level = new Random().Next(0,100);
        }

        public override string ToString()
        {
            return LastName + " " + Age + " " + Level;
        }
    }
}
