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
            Employee emp = new Employee("Brano", 20);

            Console.WriteLine($"Helo Employee {emp.name}");
           /* Vector vector = new Vector();
            vector.x = 5;
            vector.y = 10;*/

            /*Vector vector = new Vector
            {
                x = 5,
                y = 10
            };
            Console.WriteLine($"x = {vector.x}");
            Console.WriteLine($"y = {vector.y}");*/
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
        //Constructor
        public Vector(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //Fields
        public int x;
        public int y;
    }

    class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    class Employee : Person
    {
        public Employee(string n, int a) : base (n,a)
        {

        }
    }
}
