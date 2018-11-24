using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Status player = Status.Alive;
            switch (player)
            {
                case Status.Alive:
                    Console.WriteLine($"Player is {player}");
                    break;
                case Status.Injured:
                    Console.WriteLine($"Player is {player}");
                    break;
                case Status.Dead:
                    Console.WriteLine($"Player is {player}");
                    break;
                default:
                    Console.WriteLine("Player is retired.  :-D");
                    break;
            }
            Console.ReadLine();
        }

        
    }

    enum Status
    {
        Alive,
        Injured,
        Dead
    }
}
