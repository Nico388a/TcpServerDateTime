using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace AnotherServer
{
    class ServerDataTime
    {

        public void Start()
        {
            TcpListener server = new TcpListener(IPAddress.Loopback, 3003);

            server.Start();
            TcpClient socket = server.AcceptTcpClient();
            DoClient(socket);
        }


        public void DoClient(TcpClient socket)
        {
            NetworkStream ns = socket.GetStream();
            StreamWriter sw = new StreamWriter(ns);
            StreamReader sr = new StreamReader(ns);

            string str = sr.ReadLine();

            string[] strArray = str.Split('&'); //10:23&2003-10-07
            string dt = strArray[1] + " " + strArray[0];
            DateTime date = DateTime.ParseExact(dt, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("This is Nicolai");
            sw.WriteLine(date);
            sw.Flush();

            sw.Close();
           

        }
    }
}
