using System;
using System.Threading;
using OscJack.Extensions;

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

            // Send values ten times.
            var random = new Random();
            for (var k = 0; k < 10; k++)
            {
                Thread.Sleep(500);

                client.Send("/start");

                client.Send("/test",              // OSC address
                            k * 10.0f,            // First element
                            random.NextSingle()); // Second element

                client.Send("/Vector3", $"Vector3[{k}]", k*1f, k*2f, k*3f);
                client.Send("/Vector7", $"Vector7[{k}]", k*1f, k*2f, k*3f, k*4f, k*5f, k*6f, k*7f);

                client.Send("/end");

                Console.WriteLine($"Send message");
            }
        }
    }
}