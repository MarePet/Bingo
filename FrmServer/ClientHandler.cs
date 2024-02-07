using AppLogic;
using Domain;
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace FrmServer
{
    internal class ClientHandler
    {
        private Socket klijentskiSocket;
        private BinaryFormatter formatter;
        private NetworkStream stream;
        private bool kraj = false;
        public Igra Igra { get; set; }

        public int[] DobitnaKombinacija { get; set; }

        public ClientHandler(Socket klijentskiSocket)
        {
            this.klijentskiSocket = klijentskiSocket;
            formatter= new BinaryFormatter();
            stream = new NetworkStream(klijentskiSocket);
        }

        internal void HandleRequests()
        {
            Request request;
            while (!kraj)
            {
                try
                {
                    request = (Request)formatter.Deserialize(stream);
                    Response response = CreateResponse(request);
                    formatter.Serialize(stream, response);
                }
                catch (IOException ioe)
                {
                    Debug.WriteLine("At HandleRquests: " + ioe.Message);
                }
            }
        }

        private Response CreateResponse(Request request)
        {
            Response response = new Response();
            switch (request.Operacija)
            {
                case Operacija.Pogadjanje:
                    response = Controller.Instance.Pogadjanje((Pogadjanje)request.RequestObject,DobitnaKombinacija);
                    break;

                case Operacija.KrajIgre:
                    Igra = (Igra)request.RequestObject;
                    break;
                default:
                    break;
            }
            return response;
        }
    }
}