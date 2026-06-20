using Zap.Rpc;
using EchoServiceZap.Services;
using System;
using System.Net;

namespace EchoServiceZap
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var server = new TcpRpcServer())
            {
                server.AddBuffering();
                server.Main = new ZapEchoService();
                server.StartAccepting(IPAddress.Any, 5002);
                Console.WriteLine("Press RETURN to stop listening");
                Console.ReadLine();
            }
        }
    }
}
