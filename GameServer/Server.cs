using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace GameServer
{
	class Server
	{
		public static int MaxPlayers { get; private set; }
		public static int Port { get; private set; }
		public static Dictionary<int, Client> clients = new Dictionary<int, Client>();

		private static TcpListener tcpListener;

		public static void Start(int _maxPlayers, int _port) {
			InitialiseServerData();

			MaxPlayers = _maxPlayers;
			Port = _port;

			tcpListener = new TcpListener(IPAddress.Any, Port);
			tcpListener.Start();
			tcpListener.BeginAcceptTcpClient(new AsyncCallback(TCPConnectCallback),null);

			Console.WriteLine($"Server started: Port {Port}");
		}

		public static void TCPConnectCallback(IAsyncResult _result)
        {
			TcpClient _client = tcpListener.EndAcceptTcpClient(_result);
			tcpListener.BeginAcceptTcpClient(new AsyncCallback(TCPConnectCallback), null);
			Console.Write($"Incoming connection from {_client.Client.RemoteEndPoint}");
			for (int i = 1; i <= MaxPlayers; i++)
            {
				if(clients[i].tcp.socket == null)
                {
					clients[i].tcp.Connect(_client);
					return;
                }
            }

			Console.WriteLine($"{ _client.Client.RemoteEndPoint}  Connction failed: server full");

        }

		private static void InitialiseServerData()
        {
			for (int i = 1; i <= MaxPlayers; i++)
            {
				clients.Add(i, new Client(i));
            }
        }
	}
}
