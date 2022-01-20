using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountantAssistant
{
    class Client
    {
        //var for the class Login
        private string firstname;
        private string lastname;
        private string telephone;
        private string email;
        private string uidnumber;
        private string address;
        private string plz;
        private string place;
        private string country;

        //getter und setter
        #region get/set
   

        public string Firstname
        {
            get
            {
                return firstname;
            }

            set
            {
                firstname = value;
            }

        }
        public string Lastname
        {
            get
            {
                return lastname;
            }

            set
            {
                lastname = value;
            }

        }

        public string Telephone
        {
            get
            {
                return telephone;
            }

            set
            {
                telephone = value;
            }

        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }

        }

        public string Uidnumber
        {
            get
            {
                return uidnumber;
            }

            set
            {
                uidnumber = value;
            }

        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }

        }

        public string Plz
        {
            get
            {
                return plz;
            }

            set
            {
                plz = value;
            }

        }

        public string Place
        {
            get
            {
                return place;
            }

            set
            {
                place = value;
            }

        }

        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }

        }

        #endregion

        //constructor
        public Client(string firstname, string lastname, string telephone, string email, string uidnumber,string address, string plz, string place, string country)
        {
            
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Telephone = telephone;
            this.Email = email;
            this.Uidnumber = uidnumber;
            this.Address = address;
            this.Plz = plz;
            this.Place = place;
            this.Country = country;

        }

    }
}
