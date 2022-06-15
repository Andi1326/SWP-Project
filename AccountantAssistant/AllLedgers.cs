using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountantAssistant
{
    class AllLedgers
    {
        //var for the class AllLedgers
        private int idc;
        private int number;
        private string name;
        private string type;

        //get/set
        #region Get/Set

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


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        #endregion


        //constructor
        public AllLedgers(int idc, int number, string name, string type)
        {
            this.IDC = idc;
            this.Number = number;
            this.Name = name;
            this.Type = type;
        }
    }
}
