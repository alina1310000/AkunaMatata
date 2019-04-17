using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTrainingDay5
{
    class Team
    {
        public string Name { get; }

        public readonly List<FootballPlayer> Players;

        public int SumLevel { get; }

        public Trainer Trainer { get; }

        public Owner Owner { get; }
        public Team(string name, List<FootballPlayer> players, Trainer trainer, Owner owner)
        {
            this.Name = name;
            this.Players = players;
            this.Trainer = trainer;
            Owner = owner;
            this.SumLevel =  (int) (players.Sum(x=>x.Level)*trainer.Luck);
        }

        public void AddPlayer(FootballPlayer player)
        {
            Players.Add(player);
        }

        public void PrintPlayers()
        {
            var footballPlayers = Players.OrderBy(x => x.LastName);
            foreach (var player in footballPlayers)
            {
                Console.WriteLine(player);
            }
        }

        public void OrderedOlderThan30()
        {
            var footballPlayers = Players.Where(x => x.Age >= 30).OrderByDescending(x => x.Level);
            foreach (var player in footballPlayers)
            {
                Console.WriteLine(player);
            }
        }
    }
}
