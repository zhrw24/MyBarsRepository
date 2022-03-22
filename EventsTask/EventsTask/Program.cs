using System;

namespace EventsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            publisher.KeyPressed += (sender, insertChar) => Console.WriteLine($" Введено: {insertChar}");
            publisher.Run();
        }
    }
}
