using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using CS;
namespace Server
{
    class Server1
    {

        static void Main(string[] args)
        {
            Server server = new Server();
            server.StartServer();
            try
            {
                Task.Factory.StartNew(() => server.Connects());
                while (true)
                {
                    Console.WriteLine("1 - start browser\n2 - disconnect from server");
                    server.SendCommand(int.Parse(Console.ReadLine()));
                    Console.Clear();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}