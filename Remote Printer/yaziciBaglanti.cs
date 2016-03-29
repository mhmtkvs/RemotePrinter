using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection;

namespace Remote_Printer
{
    class yaziciBaglanti
    {
        #region variables

        public TcpClient clientConnection = null;
        public NetworkStream networkStream = null;
        public bool EthDisconnected;
        public bool ethConnected = false;
        public bool readEthEnd = false;
        public byte[] ethBuffer = new byte[512];
        public UInt16 ethBufferHead = 0;
        public UInt16 ethBufferTail = 0;
        public byte[] SendBuffer = new byte[32];
        public string ipAddress = "";
        public int comPort;

        #endregion

        #region SetGetFunctions

        public void setIpAddress(string arg_IPAddress)
        {
            ipAddress = arg_IPAddress;
        }

        public void setComPort(int arg_COM)
        {
            comPort = arg_COM;
        }

        public string getIpAddress()
        {
            return ipAddress;
        }

        public int getComPort()
        {
            return comPort;
        }

        #endregion

        #region ConnectionFunctions

        public bool EthernetConnection()
        {
            try
            {
                clientConnection = new TcpClient(ipAddress, comPort);
            }
            catch
            {
                return false;
            }

            networkStream = clientConnection.GetStream();
            ethConnected = true;

            Thread thReadEthernet = new Thread(new ThreadStart(getMessage));
            thReadEthernet.Start();

            //timerEthernet kullanımı yapmaya uğraşılacak.

            return true;
        }

        public void EthernetDisconnection()
        {
            try
            {
                Thread.Sleep(1000);
                networkStream.Close();
                clientConnection.Close();
                EthDisconnected = true;
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region SendGetMessageFunctions

        public void getMessage()
        {
            while (ethConnected)
            {
                try
                {
                    ethBuffer[ethBufferHead] = (byte)networkStream.ReadByte();
                    ethBufferHead = (UInt16)((ethBufferHead + 1) & 0x1FF);
                }

                catch (Exception)
                {
                    ethConnected = false;
                    Thread.Sleep(1000);
                    networkStream.Close();
                    clientConnection.Close();
                    readEthEnd = true;
                    return;
                }
            }
        }

        public void sendMessage(byte[] data, int dataLength)
        {
            try
            {
                networkStream.Write(data, 0, dataLength);
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        public void opening() //bağlantı kurulduğunda yapılması gereken işlemler bu fonksiyon ile yapılacak.
        {
        }
        public void closing() //bağlantı kapatıldığında yapılması gereken işlemler bu fonksiyon ile yapılacak.
        {
        }
    }
}
