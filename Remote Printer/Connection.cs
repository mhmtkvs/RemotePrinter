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


namespace Ethernet_Serial_Connection
{
    class Connection
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

    class Tiflex
    {
        public Connection Printer;

        public void readMessage()
        {

        }

        public void sendMessage(byte[] data, int dataLength)
        {

        }

        public void dataProcess()
        {

        }
    }

    class LogoPrinter
    {

        #region variables

        public Connection Printer;
        private int bufferState = 0;
        private byte BufferStateStart = 0;
        private string BufferMessageID = "";
        private byte BufferChkSum = 0;
        public byte[] BufferedData = new byte[128];
        public byte DataCounter = 0;
        public byte BufferedDataLength = 0;
        public string LastBufferedData = "";

        #endregion

        #region ParseFunctions
        /*-----------------------------Parse İşlemleri--------------------------------------*/
        private void Control_startOfFrameState()
        {
            switch (BufferStateStart)
            {
                case 0:
                    if (Convert.ToString((char)Printer.ethBuffer[Printer.ethBufferTail]) == "@")
                    {
                        BufferStateStart++;
                        BufferChkSum ^= Printer.ethBuffer[Printer.ethBufferTail];
                    }
                    Printer.ethBufferTail = (UInt16)((Printer.ethBufferTail + 1) & 0x1FF);
                    break;

                case 1:
                    if (Convert.ToString((char)Printer.ethBuffer[Printer.ethBufferTail]) == "0")
                    {
                        BufferStateStart++;
                        BufferChkSum ^= Printer.ethBuffer[Printer.ethBufferTail];
                    }
                    else
                    {
                        BufferStateStart = 0;
                        BufferChkSum = 0;
                    }

                    Printer.ethBufferTail = (UInt16)((Printer.ethBufferTail + 1) & 0x1FF);

                    break;

                case 2:

                    if (Convert.ToString((char)Printer.ethBuffer[Printer.ethBufferTail]) == "0")
                    {
                        BufferStateStart = 0;
                        BufferChkSum ^= Printer.ethBuffer[Printer.ethBufferTail];
                        bufferState++;
                    }
                    else
                    {
                        BufferStateStart = 0;
                        BufferChkSum = 0;
                    }

                    Printer.ethBufferTail = (UInt16)((Printer.ethBufferTail + 1) & 0x1FF);
                    break;

                default:
                    BufferStateStart = 0;
                    BufferChkSum = 0;
                    break;
            }
        }

        private void Control_messageIDState()
        {
            byte messageID = 0;

            messageID = Printer.ethBuffer[Printer.ethBufferTail];
            Printer.ethBufferTail = (UInt16)((Printer.ethBufferTail + 1) & 0x1FF);
            BufferMessageID = Convert.ToString(messageID);
            BufferChkSum ^= messageID;

            messageID = Printer.ethBuffer[Printer.ethBufferTail];
            Printer.ethBufferTail = (UInt16)((Printer.ethBufferTail + 1) & 0x1FF);
            BufferMessageID += Convert.ToString(messageID);
            BufferChkSum ^= messageID;

            bufferState++;
        }

        private void Control_dataState()
        {
            if (Convert.ToString(Printer.ethBuffer[Printer.ethBufferTail]) != "*")
            {
                BufferedData[DataCounter] = Printer.ethBuffer[Printer.ethBufferTail];
                Printer.ethBufferTail = (UInt16)((Printer.ethBufferTail + 1) & 0x1FF);

                BufferChkSum ^= BufferedData[DataCounter];
                DataCounter = (byte)((DataCounter + 1) & 0x7F);
                BufferedDataLength = (byte)(DataCounter - 1);
            }
            else
            {
                bufferState++;
                DataCounter = 0;
            }
        }

        private void Control_checkSumControlState()
        {
            if (BufferChkSum == 0)
            {
                for (int i = 0; i < BufferedDataLength; i++)
                {
                    LastBufferedData += BufferedData[i].ToString();
                }

                bufferState++;
            }
            else
            {
                bufferState = 0;
            }

        }

        private void Control_endOfFrameState()
        {
            if (Convert.ToString(Printer.ethBuffer[Printer.ethBufferTail]) == "\r")
            {
                dataProcess();
            }
            Printer.ethBufferTail = (UInt16)((Printer.ethBufferTail + 1) & 0x1FF);
            bufferState = 0;
        }
        /*------------------------------------------------------------------------------*/
        #endregion

        #region ReadWriteFunctions

        public void readMessage()   //1 ms süre ile çağırılacak fonksiyon. Ethernet bağlantısı olduğu sürece çağırılacak.
        {
            while (Printer.ethBufferHead != Printer.ethBufferTail)    // Mesaj gelmeye devam ettiği sürece alınan byte'lar değerlendirilir.
            {
                switch (bufferState)
                {
                    case 0:
                        Control_startOfFrameState();
                        break;
                    case 1:
                        Control_messageIDState();
                        break;
                    case 2:
                        Control_dataState();
                        break;
                    case 3:
                        Control_checkSumControlState();
                        break;
                    case 4:
                        Control_endOfFrameState();
                        break;
                    default:
                        bufferState = 0;
                        break;
                }
            }
        }

        public void sendMessage(string msgID, string Data)
        {
            string Message = "";
            byte[] encodedData;
            byte checkSum = 0;

            Message = "@" + "00" + msgID + Data;
            encodedData = ASCIIEncoding.ASCII.GetBytes(Message);

            for (int i = 0; i < encodedData.Length; i++)
            {
                checkSum ^= encodedData[i];
            }

            Message = checkSum.ToString() + "*" + "\r";
            encodedData = ASCIIEncoding.ASCII.GetBytes(Message);

            Printer.sendMessage(encodedData, encodedData.Length);
        }

        #endregion

        #region ProcessFunctions

        public void dataProcess()   // gelecek mesajlardan kullanılacak olanlara göre ayrıştırma işlemi sonrası bir sonuç bu fonksiyon ile çıkarılacak.
        {

        }

        #endregion
    }

    class HR500
    {

        #region Variables

        public Connection Printer;
        private int bufferState = 0;
        private byte BufferStateStart = 0;
        private UInt16 BufferMessageID = 0;
        private byte BufferChkSum = 0;
        private byte controlChecksum = 0;
        private byte[] controlEndOfFrame = new byte[2];
        public byte[] tempBufferedData = new byte[128];
        public byte[] BufferedData = new byte[128];
        public byte DataCounter = 0;
        public byte BufferedDataLength = 0;

        #endregion

        #region ParseFunctions
        /*-----------------------------Parse İşlemleri--------------------------------------*/
        private void Control_startOfFrameState()
        {
            switch (BufferStateStart)
            {
                case 0:
                    if (Printer.ethBuffer[Printer.ethBufferTail] == 0x0A)
                    {
                        BufferStateStart++;
                        BufferChkSum ^= Printer.ethBuffer[Printer.ethBufferTail];
                    }
                    Printer.ethBufferTail = (UInt16)((Printer.ethBufferTail + 1) & 0x1FF);
                    break;

                case 1:
                    if (Printer.ethBuffer[Printer.ethBufferTail] == 0x02)
                    {
                        BufferStateStart++;
                        BufferChkSum ^= Printer.ethBuffer[Printer.ethBufferTail];
                    }
                    else
                    {
                        BufferStateStart = 0;
                        BufferChkSum = 0;
                    }

                    Printer.ethBufferTail = (UInt16)((Printer.ethBufferTail + 1) & 0x1FF);

                    break;

                case 2:

                    if (Printer.ethBuffer[Printer.ethBufferTail] == 0x00)
                    {
                        BufferStateStart = 0;
                        BufferChkSum ^= Printer.ethBuffer[Printer.ethBufferTail];
                        bufferState++;
                    }
                    else
                    {
                        BufferStateStart = 0;
                        BufferChkSum = 0;
                    }

                    Printer.ethBufferTail = (UInt16)((Printer.ethBufferTail + 1) & 0x1FF);
                    break;

                default:
                    BufferStateStart = 0;
                    BufferChkSum = 0;
                    break;
            }
        }

        private void Control_messageIDState()
        {
            BufferMessageID = (UInt16)(Printer.ethBuffer[Printer.ethBufferTail]);
            BufferChkSum ^= Printer.ethBuffer[Printer.ethBufferTail];
            Printer.ethBufferTail = (UInt16)((Printer.ethBufferTail + 1) & 0x1FF);

            BufferMessageID |= (UInt16)(Printer.ethBuffer[Printer.ethBufferTail] << 8);
            BufferChkSum ^= Printer.ethBuffer[Printer.ethBufferTail];
            Printer.ethBufferTail = (UInt16)((Printer.ethBufferTail + 1) & 0x1FF);

            bufferState++;
        }

        private void Control_dataState()
        {

            int i = 0;

            tempBufferedData[DataCounter] = Printer.ethBuffer[Printer.ethBufferTail];
            Printer.ethBufferTail = (UInt16)((Printer.ethBufferTail + 1) & 0x1FF);

            DataCounter = (byte)((DataCounter + 1) & 0x7F);
            BufferedDataLength = (byte)(DataCounter - 3);

            if (Printer.ethBufferHead != Printer.ethBufferTail)
            {
                bufferState = 0;
                DataCounter = 0;

                //gelen mesaj bufferı sonuna kadar alındı. Alındıktan sonra data, checksum , endofFrame ayrıştırıldı.
                //Ayrıştırılan veriler kontrol amaçlı kullanıldı.
                for (i = 0; i < BufferedDataLength; i++)
                {
                    BufferedData[i] = tempBufferedData[i];
                    BufferChkSum ^= tempBufferedData[i];
                }

                controlChecksum = tempBufferedData[i++];
                controlEndOfFrame[0] = tempBufferedData[i++];
                controlEndOfFrame[1] = tempBufferedData[i++];

                Control_checkSumControlState();

            }
        }

        private void Control_checkSumControlState()
        {
            if (BufferChkSum == controlChecksum)
            {
                Control_endOfFrameState();
            }
            else
            {
                bufferState = 0;
            }

        }

        private void Control_endOfFrameState()
        {
            if ((controlEndOfFrame[0] == 0x0A) && (controlEndOfFrame[1] == 0x03))
            {
                dataProcess();
            }
            bufferState = 0;
        }
        /*------------------------------------------------------------------------------*/
        #endregion

        #region readWriteFunctions

        public void readMessage()
        {
            while (Printer.ethBufferHead != Printer.ethBufferTail)    // Mesaj gelmeye devam ettiği sürece alınan byte'lar değerlendirilir.
            {
                switch (bufferState)
                {
                    case 0:
                        Control_startOfFrameState();
                        break;
                    case 1:
                        Control_messageIDState();
                        break;
                    case 2:
                        Control_dataState();
                        break;
                    default:
                        bufferState = 0;
                        break;
                }
            }
        }

        public void sendMessage(byte[] data, UInt16 messageID, int dataLength)
        {
            int SendBufferLength = 0;
            byte SendChksum = 0;
            int j = 0;

            Printer.SendBuffer[j++] = 0X0A;
            Printer.SendBuffer[j++] = 0X02;
            Printer.SendBuffer[j++] = 0X00;
            Printer.SendBuffer[j++] = (byte)(messageID);
            Printer.SendBuffer[j++] = (byte)(messageID >> 8);

            for (byte i = 0; i < dataLength; i++)
            {
                Printer.SendBuffer[j++] = data[i];
            }

            for (byte i = 0; i < j; i++)
            {
                SendChksum ^= Printer.SendBuffer[i];
            }

            Printer.SendBuffer[j++] = SendChksum;
            Printer.SendBuffer[j++] = 0x0A;
            Printer.SendBuffer[j++] = 0x03;
            SendBufferLength = j;

            Printer.sendMessage(Printer.SendBuffer, SendBufferLength);

        }

        #endregion

        public void dataProcess()
        {

        }
    }
}





