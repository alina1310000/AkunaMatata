using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EpamTrainingDay5
{
    class Game
    {
        public event EventHandler<GameEventArgs> Goal;
        public event EventHandler<GameEventArgs> BreakingOfRules;
        public Game(Team firstTeam, Team secondTeam, Judge judge)
        {
            FirstTeam = firstTeam;
            SecondTeam = secondTeam;
            Judge = judge;
        }

        public Team FirstTeam { get; }

        public Team SecondTeam { get; }

        public Judge Judge { get; }
        public void GetWinner()
        {
            var scoreFirstTeam = FirstTeam.SumLevel;
            var scoreSecondTeam = SecondTeam.SumLevel;
            if (Judge.Preference == 1)
            {
                scoreFirstTeam += 35;
            }
            else if (Judge.Preference == 2)
            {
                scoreSecondTeam += 35;
            }

            var max = scoreFirstTeam > scoreSecondTeam ? scoreFirstTeam : scoreSecondTeam;

            Console.WriteLine("Score of 1 team: " + scoreFirstTeam);
            Console.WriteLine("Score of 2 team: " + scoreSecondTeam);
            if ((scoreFirstTeam == max && scoreFirstTeam - scoreSecondTeam <= scoreFirstTeam * 0.1)
                || scoreSecondTeam == max && scoreSecondTeam - scoreFirstTeam <= scoreSecondTeam * 0.1)
            {
                Console.WriteLine("Draw!");

            }
            else if (scoreFirstTeam > scoreSecondTeam)
            {
                Console.WriteLine(FirstTeam.Name + " win!");
            }
            else
            {
                Console.WriteLine(SecondTeam.Name + " win!");
            }
        }

        public void Start()
        {
            try
            {
                Console.WriteLine("Game started!");
                throw new GameStartedException();
            }
            catch (GameStartedException)
            {
                Console.WriteLine("Game returned!");
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        public void OnGoal(string playerLastName)
        {
            var args = new GameEventArgs(playerLastName);
            Goal?.Invoke(this, args);
        }

        public void OnBreaking(string playerLastName)
        {
            var args = new GameEventArgs(playerLastName);
            BreakingOfRules?.Invoke(this, args);
        }
    }

    internal class GameEventArgs : EventArgs
    {
        public string NameOfPlayer { get; set; }

        public GameEventArgs(string nameOfPlayer)
        {
            NameOfPlayer = nameOfPlayer;
        }
    }
}
