using System.Net.Sockets;

namespace OscJack.Extensions
{
    public static partial class OscClientExtensions
    {
        public static void Send(this OscClient client, string address, string element1, 
                                float element2, float element3, float element4)
        {            
            client.Encoder.Clear();
            client.Encoder.Append(address);
            client.Encoder.Append(",sfff");
            client.Encoder.Append(element1);
            client.Encoder.Append(element2);
            client.Encoder.Append(element3);
            client.Encoder.Append(element4);
            client.Socket.Send(client.Encoder.Buffer, client.Encoder.Length, SocketFlags.None);
        }

        public static void Send(this OscClient client, string address, string element1, 
                                float element2, float element3, float element4, float element5, float element6, float element7, float element8)
        {            
            client.Encoder.Clear();
            client.Encoder.Append(address);
            client.Encoder.Append(",sfffffff");
            client.Encoder.Append(element1);
            client.Encoder.Append(element2);
            client.Encoder.Append(element3);
            client.Encoder.Append(element4);
            client.Encoder.Append(element5);
            client.Encoder.Append(element6);
            client.Encoder.Append(element7);
            client.Encoder.Append(element8);
            client.Socket.Send(client.Encoder.Buffer, client.Encoder.Length, SocketFlags.None);
        }
    }
}