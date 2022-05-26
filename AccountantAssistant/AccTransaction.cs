using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountantAssistant
{
    class AccTransaction
    {
        //var for the class AccTransaction

        private int idc;
        private int ledger1;
        private int ledger2;
        private string netto;
        private string brutto;
        private string ust;
        private int salestaxrate;
        private string referenceNumber;
        private string date;

        //get/set
        #region get/set

        public int Idc
        {
            get
            {
                return idc;
            }
            set
            {
                idc = value;
            }
        }

        public int Ledger1
        {
            get
            {
                return ledger1;
            }
            set
            {
                ledger1 = value;
            }
        }

        public int Ledger2
        {
            get
            {
                return ledger2;
            }
            set
            {
                ledger2 = value;
            }
        }

        public string Netto
        {
            get
            {
                return netto;
            }
            set
            {
                netto = value;
            }
        }

        public string Brutto
        {
            get
            {
                return brutto;
            }
            set
            {
                brutto = value;
            }
        }

        public string Ust
        {
            get
            {
                return ust;
            }
            set
            {
                ust = value;
            }
        }

        public int Salestaxrate
        {
            get
            {
                return salestaxrate;
            }
            set
            {
                salestaxrate = value;
            }
        }

        public string ReferenceNumber
        {
            get
            {
                return referenceNumber;
            }
            set
            {
                referenceNumber = value;
            }
        }

        public string Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }

        #endregion

        //constructor
        public AccTransaction (int idc, int ledger1, int ledger2, string netto, string brutto, string ust, int salestaxrate, string referenceNumber,string date)
        {
            this.Idc = idc;
            this.Ledger1 = ledger1;
            this.Ledger2 = ledger2;
            this.Netto = netto;
            this.Brutto = brutto;
            this.Ust = ust;
            this.Salestaxrate = salestaxrate;
            this.referenceNumber = referenceNumber;
            this.Date = date;
        }
    }
}
