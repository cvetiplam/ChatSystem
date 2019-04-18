using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class MyTcpClient
    {
        TcpClient _client;
        StreamReader streamReader;
        StreamWriter streamWriter;
        public string Name { get;}

        public MyTcpClient()
        {
            _client = new TcpClient();
            _client.Connect("127.0.0.1", 23);
        }

        public void HandleCommunication()
        {

        }


    }
}
