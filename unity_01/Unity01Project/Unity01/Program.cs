using System;
using Unity01.Part01TheGameExample;

namespace Unity01
{
    class Program
    {
        static void Example01Statements()
        {
            // Executing a simple statement that prints our the
            // given text to standard output - in our case, the console
            Console.WriteLine("Hello my dear students!");
        }

        static void Example02Types()
        {
            // We create some variables and write them out to standard output
            int x = 10;
            int y = x + 20;
            Console.WriteLine("int x is " + x);
            Console.WriteLine("int y is " + y);

            bool t = true;
            Console.WriteLine("bool t is " + t);

            float ingPoint = 3.14f;
            Console.WriteLine("float ingPoint is " + ingPoint);
        }

        static void Example03IfStatement()
        {
            int x = 4;
            bool even = x % 2 == 0;
            if (even)
            {
                Console.WriteLine(x + " is even!");
            }
            else
            {
                Console.WriteLine(x + " is not even!");
            }
            
            // We can also create multiple branches
            int i = 2;
            if (i == 0)
            {
                Console.WriteLine("i = 0");
            }
            else if (i == 1)
            {
                
                Console.WriteLine("i = 1");
            }
            else if (i == 2)
            {
                Console.WriteLine("i = 2");
            }
            else
            {
                Console.WriteLine("i is whatever :)");
            }
        }

        static void Example04Loops()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello");
            }
        }

        static void Example05Classes()
        {
            Player p = new Player(new Vec2());
            Console.WriteLine(p);
            
            p.ReduceHealth(50);
            Console.WriteLine(p);
            
            Console.WriteLine("Player is alive: " + p.IsAlive());
            
            p.Position.Translate(3f, 2f);
            Console.WriteLine(p);
            
            p.Position.Translate(new Vec2(-3f, -2f));
            Console.WriteLine(p);
            
            p.ReduceHealth(52);
            Console.WriteLine(p);
        }

        static void Main(string[] args)
        {
            Example05Classes();
        }
    }
}