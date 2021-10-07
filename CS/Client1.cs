using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace CS
{
    class Client1
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.Connect();
            while (true)
                client.GetServerCommand(client.GetMsg());
        }
    }
}