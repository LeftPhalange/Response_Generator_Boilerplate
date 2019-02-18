using System;
using Client.Examples;

namespace Client
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // using the Magic 8-Ball example
            _8Ball _eightBall = new _8Ball();
            Console.WriteLine("Magic 8-Ball says: " + _eightBall.GenerateResponse());
            Console.Write("Do it again? (Y/N) ");
            if (Console.ReadLine().Trim().ToLower() == "y")
                Main(null);
        }
    }
}
