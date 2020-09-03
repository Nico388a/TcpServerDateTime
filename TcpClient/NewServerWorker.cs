using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TcpServerProgram
{
    class NewServerWorker
    {
        private bool _stop;
        public void Start()
        {
            TcpListener server = new TcpListener(IPAddress.Loopback,3001);

            server.Start();
            TcpClient socket = server.AcceptTcpClient();
            while (! _stop)
            {

                DoClient(socket);
                
            }
            
        }

        public void DoClient(TcpClient socket)
        {
            NetworkStream ns = socket.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);

            string str = sr.ReadLine();
            Console.WriteLine("This is Nicolai");
            str = str.Replace('.', ',');
            string[] input= str.Split(' ');
            if (input[0] == "Stop")
            {
                sw.WriteLine("Disconnecting");
                sw.Flush();
                _stop = true;
                socket.Close();
                return;
            }
            double nr1 = Convert.ToDouble(input[1]);
            double nr2 = Convert.ToDouble(input[2]);
            switch (input[0])
            {
                case "+": sw.WriteLine(nr1 + nr2); 
                    break;

                case "*": sw.WriteLine(nr1 * nr2);
                    break;

                case "/": sw.WriteLine(nr1 / nr2);
                    break;

                case "-": sw.WriteLine(nr1 - nr2);
                    break;

                default: sw.WriteLine("Inputtet var forkert");
                    break;
            }
            
            sw.Flush();

        }
    }
}
