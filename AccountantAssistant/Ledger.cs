using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountantAssistant
{
    class Ledger
    {
        //var for the class Login
        private int idle;
        private int idc;
        private int number;
        private int contraLedger;
        private decimal debitValue;
        private decimal creditValue;
        private string referenceNumber;
        private string date;


        //get/set
        #region Get/Set

        public int IDLE
        {
            get
            {
                return idle;
            }
            set
            {
                idle = value;
            }
        }

        public int IDC
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

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        public int ContraLedger
        {
            get
            {
                return contraLedger;
            }
            set
            {
                contraLedger = value;
            }
        }

        public decimal DebitValue
        {
            get
            {
                return debitValue;
            }
            set
            {
                debitValue = value;
            }
        }

        public decimal CreditValue
        {
            get
            {
                return creditValue;
            }
            set
            {
                creditValue = value;
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


        #endregion


        //constructor
        public Ledger(int idle, int idc, int number, int contraLedger, decimal debitValue, decimal creditValue, string referenceNumber, string date)
        {
            this.IDLE = idle;
            this.IDC = idc;
            this.Number = number;
            this.ContraLedger = contraLedger;
            this.DebitValue = debitValue;
            this.CreditValue = creditValue;
            this.Date = date;
            this.ReferenceNumber = referenceNumber;
        }
    }
}
