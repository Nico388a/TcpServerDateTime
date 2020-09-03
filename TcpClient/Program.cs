using System;

namespace TcpServerProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            NewServerWorker worker = new NewServerWorker();
            worker.Start();

            Console.ReadLine();
        }
    }
}
