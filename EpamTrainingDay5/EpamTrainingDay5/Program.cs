using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EpamTrainingDay5
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstTeam = new Team("FirstTeam", new List<FootballPlayer>
           {
               new FootballPlayer("Gray",26),
               new FootballPlayer("Smith",29),
               new FootballPlayer("Paterson",34)
           }, new Trainer("Trey"),new Owner(6000000,"Trump"));
            var secondTeam = new Team("SecondTeam", new List<FootballPlayer>
           {
               new FootballPlayer("Rozo",35),
               new FootballPlayer("Messi",34),
               new FootballPlayer("Richardson",24)
           }, new Trainer("Grab"),new Owner(5000000,"Gorosh"));
            firstTeam.PrintPlayers();
            Console.WriteLine();
            firstTeam.OrderedOlderThan30();
            Console.WriteLine();
            secondTeam.PrintPlayers();
            Console.WriteLine();
            secondTeam.OrderedOlderThan30();
            Console.WriteLine();
            var judge = new Judge("Poto",firstTeam.Owner,secondTeam.Owner);
            var game = new Game(firstTeam, secondTeam, judge);
            game.Start();
            game.Goal += judge.Goal;
            game.BreakingOfRules += judge.BreakingOfRules;
            game.OnGoal(firstTeam.Players[1].LastName);
            game.OnBreaking(secondTeam.Players[1].LastName);
            game.OnGoal(firstTeam.Players[0].LastName);
            game.GetWinner();
        }
    }
}
