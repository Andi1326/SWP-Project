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
        private int contraLedger;
        private decimal debitValue;
        private decimal creditValue;



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


        #endregion


        //constructor
        public Ledger(int idle, int idc, int contraLedger, decimal debitValue, decimal creditValue)
        {
            this.IDLE = idle;
            this.IDC = idc;
            this.ContraLedger = contraLedger;
            this.DebitValue = debitValue;
            this.CreditValue = creditValue;
        }
    }
}
