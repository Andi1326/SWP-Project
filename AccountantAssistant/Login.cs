using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountantAssistant
{
    class Login
    {
        //var for the class Login
        private string username;
        private string password;
        private string sq1;
        private string sq2;
        private string sq1question;
        private string sq2question;
        private string role;
        private int darkmode;

        //get/set
        #region Get/Set

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }


        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public string Sq1
        {
            get
            {
                return sq1;
            }
            set
            {
                sq1 = value;
            }
        }


        public string Sq2
        {
            get
            {
                return sq2;
            }
            set
            {
                sq2 = value;
            }
        }

        public string Sq1question
        {
            get
            {
                return sq1question;
            }
            set
            {
                sq1question = value;
            }
        }

        public string Sq2question
        {
            get
            {
                return sq2question;
            }
            set
            {
                sq2question = value;
            }
        }

        public string Role
        {
            get
            {
                return role;
            }
            set
            {
                role = value;
            }
        }

        public int Darkmode
        {
            get
            {
                return darkmode;
            }
            set
            {
                darkmode = value;
            }
        }

        #endregion

        //constructor
        public Login(string username, string password, string sq1, string sq2, string sq1question, string sq2question, string role, int darkmode)
        {
            this.Username = username;
            this.Password = password;
            this.Sq1 = sq1;
            this.Sq2 = sq2;
            this.Sq1question = sq1question;
            this.Sq2question = sq2question;
            this.Role = role;
            this.Darkmode = darkmode;
        }
    }
}
