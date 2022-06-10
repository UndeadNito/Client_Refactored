using System.Net.Sockets;
using System.Net;

namespace Client_Refactored
{
    internal class Program
    {
        private const int _port = 2020;
        private static readonly IPAddress _address = 
            Dns.GetHostEntry(IPAddress.Loopback).AddressList.Last();

        private static TcpClient? _client;
        private static NetworkStream? _clientStream;
        private static MessageProvider? _provider;

        [STAThread]
        static void Main()
        {
            _client = new();
            try
            {
                _client.Connect(_address, _port);
            }
            catch (Exception)
            {
                MessageBox.Show("Server ofline");
                return;
            }

            if (!_client.Connected) throw new NotImplementedException();

            _clientStream = _client.GetStream();
            _provider = new(_clientStream);

            ApplicationConfiguration.Initialize();
            var mainForm = new LogInForm(_provider);
            mainForm.Show();
            Application.Run();
        }

        static void Main1()
        {
            _client = new();
            try
            {
                _client.Connect(_address, _port);
            }
            catch (Exception)
            {
                MessageBox.Show("Server ofline");
                return;
            }

            if (!_client.Connected) throw new NotImplementedException();

            _clientStream = _client.GetStream();
            _provider = new(_clientStream);

            ApplicationConfiguration.Initialize();
            Application.Run(new AddForm(_provider));
        }
    }
}