using System;
using System.Threading;
using OscJack;

namespace OscJack.SampleApp.Client
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine($"///////////////////////////////////");
            Console.WriteLine($"///     OscJack sample apps     ///");
            Console.WriteLine($"///            Client           ///");
            Console.WriteLine($"///////////////////////////////////");

            var port = 9000;

            Console.WriteLine($"-----------------------------------");
            Console.WriteLine($"Port: {port}");
            Console.WriteLine($"-----------------------------------");

            // IP address, port number
            var client = new OscClient("127.0.0.1", port);

            // Send two-component float values ten times.
            var random = new Random();
            for (var i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                client.Send("/test",              // OSC address
                            i * 10.0f,            // First element
                            random.NextSingle()); // Second element
                Console.WriteLine($"Send message");
            }
        }
    }
}