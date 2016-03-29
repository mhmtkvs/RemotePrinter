using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Remote_Printer
{
    class logoPrinterSurucu
    {
        #region variables

        private yaziciBaglanti Printer;
        private int bufferState = 0;
        private byte BufferStateStart = 0;
        private string BufferMessageID = "";
        private byte BufferChkSum = 0;
        public byte[] BufferedData = new byte[128];
        public byte DataCounter = 0;
        public byte BufferedDataLength = 0;
        public string LastBufferedData = "";

        private int yaziciID;

        #endregion

        #region SetGetFunctions

        public void setYaziciID(int _yaziciID)
        {
            this.yaziciID = _yaziciID;
        }

        public int getYaziciID()
        {
            return this.yaziciID;
        }

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

        #region constructor
        public logoPrinterSurucu()
        {
 
        }

        public logoPrinterSurucu(string _ipAdres, int _comPort, int _yaziciID)
        {
            Printer = new yaziciBaglanti();
            Printer.setIpAddress(_ipAdres);
            Printer.setComPort(_comPort);
            this.yaziciID = _yaziciID;
        }

        #endregion

    }
}
