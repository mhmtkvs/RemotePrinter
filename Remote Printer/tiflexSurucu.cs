using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Remote_Printer
{
    class tiflexSurucu
    {
        private yaziciBaglanti Printer;

        private int yaziciID;

        public void readMessage()
        {

        }

        public void sendMessage(byte[] data, int dataLength)
        {

        }

        public void dataProcess()
        {

        }

        #region constructor
        public tiflexSurucu()
        {
 
        }

        public tiflexSurucu(string _ipAdres, int _comPort, int _yaziciID)
        {
            Printer = new yaziciBaglanti();
            Printer.setIpAddress(_ipAdres);
            Printer.setComPort(_comPort);
            this.yaziciID = _yaziciID;
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
    }
}
