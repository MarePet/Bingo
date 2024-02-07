using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace FrmServer
{
    internal class Server
    {
        private Socket osluskujuciSocket;
        private List<ClientHandler> klijenti = new List<ClientHandler>();
        public Igra Igra { get; set; }

        public int[] DobitnaKombinacija { get; set; }

        public Server()
        {
            osluskujuciSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        public void Start()
        {
            osluskujuciSocket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999));
            osluskujuciSocket.Listen(1000);
        }
        public void HandleClients()
        {
            while (true)
            {
                Socket klijentskiSocket = osluskujuciSocket.Accept();
                ClientHandler klijent = new ClientHandler(klijentskiSocket);
                klijent.DobitnaKombinacija = DobitnaKombinacija;
                klijenti.Add(klijent);
                Thread nitKlijenta = new Thread(klijent.HandleRequests);
                nitKlijenta.Start();
            }
        }

        public bool Win()
        {
            foreach (ClientHandler klijent in klijenti.ToList())
            {
                if (klijent.Igra == null) break;
                Igra = klijent.Igra;
                if (klijent.Igra.Rezultat == "Pobedio") return true;
                if (klijent.Igra.Rezultat == "Izgubio") return true;
            }
            return false;
        }
    }
}
