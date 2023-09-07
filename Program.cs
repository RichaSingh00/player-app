using PlayerApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player[] players =
            {
                new Player(1,"Richa",22),
                new Player(2,"Barbie",23),
                new Player(3,"Stacy",23),
                new Player(4,"Jessi",35)
            };
            foreach (Player player in players)
            {
                Console.WriteLine(player.GetDetails());
                Console.WriteLine("-----------------------------------------------------------");
            }
            Console.WriteLine("The elder amongst the players is: " + Player.WhoIsElder(players).GetDetails());

        }
    }
}
