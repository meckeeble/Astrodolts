using System;
using System.Threading;

namespace GameServer
{
    class Program
    {

        public static bool isRunning = false;
        static void Main(string[] args)
        {
            Console.Title = "Astrodolts Server";
            isRunning = true;
            Console.WriteLine("Starting Programme");

            Thread mainThread = new Thread(new ThreadStart(MainThread));
            mainThread.Start();

            Server.Start(8, 5516);

        }

        private static void MainThread()
        {
            Console.WriteLine($"Main Thread started. Tickrate: {Constants.TICKS_PER_SEC}");
            DateTime _nextLoop = DateTime.Now;

            while (isRunning)
            {
                while(_nextLoop < DateTime.Now)
                {
                    GameLogic.Update();

                    _nextLoop = _nextLoop.AddMilliseconds(Constants.MS_PER_TICK);

                    if(_nextLoop > DateTime.Now)
                    {
                        Thread.Sleep(_nextLoop - DateTime.Now);
                    }
                }
            }
        }
    }
}
