using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TcpServerProgram  
{
    class ServerWorker
    {
        ////Opret Server
        //public void Start()
        //{
        //    //Loopback er en unik IP adress, men for at vide den skal vende tilbage med det samme.
        //    TcpListener server = new TcpListener(IPAddress.Loopback, 7);
        //    server.Start();
        //    while (true)
        //    {
        //        //Programmet står og venter på en connection
        //        TcpClient tempSocket = server.AcceptTcpClient();
        //        //Task Tempsocket venter til denne task er færdig
        //        Task.Run(() =>
        //        {
        //            DoClient(tempSocket);
        //        });
        //    }

        //}

        ////DoClientMetoden holder orden i serveren
        //public void DoClient(TcpClient socket)
        //{
            
        //    //Stream er ligsom når man udveksler data
        //    NetworkStream ns = socket.GetStream();
        //    //Læse information
        //    StreamReader sr = new StreamReader(ns);
        //    //Skriver til forbindelsen
        //    StreamWriter sw = new StreamWriter(ns);

        //    //læser og returnere det som en string
        //    string str = sr.ReadLine();
        //    Console.WriteLine("Hallo from Nicolai");
        //    //Den laver alle bogstaver om til store bogstaver og giver en kopi tilbage
        //    string UpperStr = str.ToUpper();

        //    //samle resultater
        //    sw.WriteLine(UpperStr);
        //    sw.Flush();
            
        //    //To see if I can call the server at the same time
        //    Thread.Sleep(5000);
        //    socket.Close();
        //}
        
    }
}
