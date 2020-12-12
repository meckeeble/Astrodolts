using System;

namespace GameServer
{
    //7:15
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Astrodolts Server";
            Console.WriteLine("Starting Programme");

            Server.Start(8, 5516);

            Console.ReadKey();
        }
    }
}
