using System;
using System.Net.Sockets;

namespace AnotherServer
{
    class Program
    {
        static void Main(string[] args)
        {
            ServerDataTime worker = new ServerDataTime();

            worker.Start();
            Console.ReadLine();
        }
    }
}
