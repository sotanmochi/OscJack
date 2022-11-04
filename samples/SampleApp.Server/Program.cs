using System;

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
                "/start", // OSC address
                (string address, OscDataHandle data) => {
                    Console.WriteLine("----- Start -----");
                }
            );

            server.MessageDispatcher.AddCallback(
                "/end", // OSC address
                (string address, OscDataHandle data) => {
                    Console.WriteLine("------ End ------");
                }
            );

            server.MessageDispatcher.AddCallback(
                "/test", // OSC address
                (string address, OscDataHandle data) => {
                    Console.WriteLine(string.Format("({0}, {1})",
                        data.GetElementAsFloat(0),
                        data.GetElementAsFloat(1)));
                }
            );

            server.MessageDispatcher.AddCallback(
                "/Vector3", // OSC address
                (string address, OscDataHandle data) => {
                    Console.WriteLine(string.Format("{0}: ({1}, {2}, {3})",
                        data.GetElementAsString(0),
                        data.GetElementAsFloat(1),
                        data.GetElementAsFloat(2),
                        data.GetElementAsFloat(3)));
                }
            );

            server.MessageDispatcher.AddCallback(
                "/Vector7", // OSC address
                (string address, OscDataHandle data) => {
                    Console.WriteLine(string.Format("{0}: ({1}, {2}, {3}, {4}, {5}, {6}, {7})",
                        data.GetElementAsString(0),
                        data.GetElementAsFloat(1),
                        data.GetElementAsFloat(2),
                        data.GetElementAsFloat(3),
                        data.GetElementAsFloat(4),
                        data.GetElementAsFloat(5),
                        data.GetElementAsFloat(6),
                        data.GetElementAsFloat(7)));
                }
            );
        }
    }
}