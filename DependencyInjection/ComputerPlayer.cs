using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class ComputerPlayer : IPlayer
    {
        Random _random = new Random();
        public Choice GetChoice()
        {
            Choice p2 = (Choice)_random.Next(0, 3);
            Console.WriteLine($"Player 2 picked: {p2.ToString()}");

            return p2;
        }
    }
}
