using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTrainingDay5
{
    class GameStartedException:Exception
    {
        public GameStartedException()
        {
            Console.WriteLine("Game stopped!");
        }
    }
}
