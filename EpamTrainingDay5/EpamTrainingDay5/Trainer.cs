using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTrainingDay5
{
    class Trainer
    {

        public string LastName { get; }

        public double Luck { get; }

        public Trainer(string lastName)
        {
            LastName = lastName;
            this.Luck = new Random().NextDouble()+0.5;
        }
    }
}
