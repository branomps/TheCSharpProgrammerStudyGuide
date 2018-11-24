﻿using System;
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
           /* Vector vector = new Vector();
            vector.x = 5;
            vector.y = 10;*/

            Vector vector = new Vector
            {
                x = 5,
                y = 10
            };
            Console.WriteLine($"x = {vector.x}");
            Console.WriteLine($"y = {vector.y}");
           /* Status player = Status.Alive;
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
            }*/
            Console.ReadLine();
        }

        
    }

    enum Status : byte
    {
        Alive = 1,
        Injured,
        Dead
    }

    struct Vector
    {
        public int x;
        public int y;
    }
}
