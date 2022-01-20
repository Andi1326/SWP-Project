using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountantAssistant
{
    class AccTransaction
    {


        private int idc;
        private int ledger1;
        private int ledger2;
        private decimal netto;
        private decimal brutto;
        private decimal ust;
        private int salestaxrate;
        private string referenceNumber;
        private string date;


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

        public decimal Netto
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

        public decimal Brutto
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

        public decimal Ust
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

        public AccTransaction (int idc, int ledger1, int ledger2, decimal netto, decimal brutto, decimal ust, int salestaxrate, string referenceNumber,string date)
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
