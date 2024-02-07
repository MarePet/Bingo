using Domain;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace KlijentskiInterfejs
{
    public class Communication
    {
        private static Communication instance;
        private Socket socket;
        private BinaryFormatter formatter;
        private NetworkStream stream;

        private Communication()
        {

        }

        public static Communication Instance
        {
            get
            {
                if (instance == null) instance = new Communication();
                return instance;
            }
        }
        public void Connect()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9999);
            formatter = new BinaryFormatter();
            stream = new NetworkStream(socket);
        }
        public void Send(Request request)
        {
            formatter.Serialize(stream, request);
        }
        public Response Recieve()
        {
            return (Response)formatter.Deserialize(stream);
        }
    }
}
