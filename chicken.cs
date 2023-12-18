using System;
using System.Threading;

internal class Program
{
    static void ChickenThread()
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("Яйцо");
        }
    }

    private static void Main(string[] args)
    {
        Thread chicken = new Thread(ChickenThread);
        chicken.Start();
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("Курица");
        }
        ThreadAnswer(chicken);
    }

    static void ThreadAnswer(Thread chicken)
    {
        bool ans = chicken.IsAlive;
        Console.WriteLine(ans ? "Спор Окончен. Победило Яйцо." : "Спор окончен. Победила Курица.");
    }
}