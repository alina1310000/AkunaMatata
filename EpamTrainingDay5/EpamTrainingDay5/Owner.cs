using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTrainingDay5
{
    class Owner
    {
        public Owner(int budgetForGame, string name)
        {
            BudgetForGame = budgetForGame;
            Name = name;
        }

        public string Name { get; }

        public int BudgetForGame { get; }

        
    }
}
