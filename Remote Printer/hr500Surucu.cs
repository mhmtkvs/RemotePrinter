using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Remote_Printer
{
    class hr500Surucu
    {
        #region Variables

        private yaziciBaglanti Printer;
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

        private int yaziciID;

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
        
        #region constructor
        
        public hr500Surucu()
        {
 
        }

        public hr500Surucu(string _ipAdres, int _comPort, int _yaziciID)
        {
            Printer = new yaziciBaglanti();
            Printer.setIpAddress(_ipAdres);
            Printer.setComPort(_comPort);
            this.yaziciID = _yaziciID;
        }

        #endregion

        public void dataProcess()
        {

        }
    }
}
