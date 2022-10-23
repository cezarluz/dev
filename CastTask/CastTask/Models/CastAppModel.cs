using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace CastTask.Models
{
    public class CastAppModel
    {
        public bool IsConnected { get; set; }
        public int Speed { get; set; }

        private TcpClient socketConnection;

        public CastAppModel()
        {
            IsConnected = false;
            Speed = 1;  
        }

        public bool ConnectToTcpServer()
        {
            try
            {
                socketConnection = new TcpClient("localhost", 8052);
                if (socketConnection == null)
                {
                    return false;
                }
                NetworkStream stream = socketConnection.GetStream();
                if (stream.CanWrite)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Connection Exception: " + e);
            }

            return false;
        }
        public void SendMessage(string message)
        {
            if (socketConnection == null)
            {
                return;
            }
            try
            {			
                NetworkStream stream = socketConnection.GetStream();
                if (stream.CanWrite)
                {
                    string clientMessage = message;            
                    byte[] clientMessageAsByteArray = Encoding.ASCII.GetBytes(clientMessage);              
                    stream.Write(clientMessageAsByteArray, 0, clientMessageAsByteArray.Length);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Sending Message Exception: " + e);
            }
        }
    }
}
