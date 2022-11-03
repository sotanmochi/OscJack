using System;
using OscJack;

namespace OscJack.SampleApp.Server
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine($"///////////////////////////////////");
            Console.WriteLine($"///     OscJack sample apps     ///");
            Console.WriteLine($"///            Server           ///");
            Console.WriteLine($"///////////////////////////////////");

            var port = 9000;

            Console.WriteLine($"-----------------------------------");
            Console.WriteLine($"Port: {port}");
            Console.WriteLine($"-----------------------------------");

            var server = new OscServer(port); // Port number

            server.MessageDispatcher.AddCallback(
                "/test", // OSC address
                (string address, OscDataHandle data) => {
                    Console.WriteLine(string.Format("({0}, {1})",
                        data.GetElementAsFloat(0),
                        data.GetElementAsFloat(1)));
                }
            );
        }
    }
}