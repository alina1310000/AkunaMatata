using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTrainingDay5
{
    class Judge
    {
        public Judge(string name, Owner owner1, Owner owner2)
        {
            Preference = owner1.BudgetForGame >= owner2.BudgetForGame ? 1 : 2;
            Name = name;
        }

        public string Name { get; }

        public int Preference { get; }
        public void Goal(object sender, GameEventArgs e)
        {
            Console.WriteLine(e.NameOfPlayer + " scored!");
        }

        public void BreakingOfRules(object sender, GameEventArgs e)
        {
            Console.WriteLine(e.NameOfPlayer + " broke of rules!");
        }
    }
}
