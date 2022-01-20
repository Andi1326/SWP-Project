using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Console;
using System.Data;
using System.Windows.Forms;

namespace AccountantAssistant
{
    class Serverconnection
    {
        public static SqlConnection con = new SqlConnection("server = (localdb)\\MSSQLLocalDB ; Integrated Security = true");
        public static SqlCommand cmd = new SqlCommand();

        private static SqlDataReader dr;

        //creating databases
        public static void Tryconnect() 
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "if not exists(select * from sys.databases where name = 'ACAS') begin create database [ACAS] end";
                cmd.ExecuteNonQuery();
                con.Close();
                con.ConnectionString = con.ConnectionString + "; database = 'ACAS'";
                con.Open();

                cmd.CommandText = "use [ACAS] if not exists(select * from sysobjects where name = 'Login') begin create table Login (IDL int Identity(1,1) primary key,username varchar(50), password varchar(50), sq1 varchar(50), sq2 varchar(50), sq1question varchar(50), sq2question varchar(50), role varchar(50)) end";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "use [ACAS] if not exists(select * from sysobjects where name = 'Client') begin create table Client (IDC int Identity(1,1) primary key, firstname varchar(50), lastname varchar(50), telephone varchar(50), eMail varchar(50), uidNumber varchar(50), adress varchar(50), plz varchar(50), place varchar(50),country varchar(50)) end";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "use [ACAS] if not exists(select * from sysobjects where name = 'Ledger') begin create table Ledger (IDLE int primary key, IDC int, contraLedger int, debitValue decimal, creditValue decimal, referenceNumber varchar(50), date varchar(50)) end";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "use [ACAS] if not exists(select * from sysobjects where name = 'AllLedgers') begin create table AllLedgers (IDLE int Identity(1,1) primary key, number int, name varchar(50), type varchar(50)) end";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "use [ACAS] if not exists(select * from sysobjects where name = 'AccTransaction') begin create table AccTransaction (IDT int Identity(1,1) primary key, IDC int, ledger1 int, ledger2 int, netto decimal, brutto decimal, ust decimal, salestaxrate int, referenceNumber varchar(50), date varchar(50)) end";
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "The Database or the Table can't be created");
            }
        }

        public static bool Proofuser(TextBox username)
        {
            //proofs if the user exists or not
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select username from login";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (username.Text == dr["username"].ToString())
                {
                    con.Close();
                    return true;
                }
            }
            con.Close();
            return false;
        }

        public static bool Proofpassword(TextBox password, string username)
        {
            //Proof if the password matches with the user
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select password from login  where username = '" + username + "'";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (password.Text == dr["password"].ToString())
                {
                    con.Close();
                    return true;
                }
            }
            con.Close();
            return false;
        }

        public static void InsertDataLogin(Login login)
        {
            //inserts the data into LOGIN
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Insert into Login (username, password, sq1, sq2, sq1question, sq2question, role ) values ('" + login.Username + "', '" + login.Password + "', '" + login.Sq1 + "', '" + login.Sq2 + "','" + login.Sq1question + "','" + login.Sq2question + "','" + login.Role + "');";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Data can not be insert");
            }
        }

        public static void InsertDataClient(Client client)
        {
            //inserts the data into Client
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Insert into Client (firstname, lastname, telephone, email, uidnumber, address, plz , place , country) values ('" + client.Firstname + "', '" + client.Lastname + "', '" + client.Telephone + "', '" + client.Email + "','" + client.Uidnumber + "','" + client.Address + "','" + client.Plz + "','" + client.Place + "','" + client.Country + "');";
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Data can't be insert");
            }
        }


        public static void InsertDataAccTransaction(AccTransaction accTransaction)
        {
           //inserts the data into AccTransaction
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Insert into AccTransaction (idc, ledger1, ledger2, netto, brutto, ust, salestaxrate , referenceNumber , date ) values ('" + accTransaction.Idc + "', '" + accTransaction.Ledger1 + "', '" + accTransaction.Ledger2 + "', '" + accTransaction.Netto + "','" + accTransaction.Brutto + "','" + accTransaction.Ust + "','" + accTransaction.Salestaxrate + "','" + accTransaction.ReferenceNumber  + "','" + accTransaction.Date + "');";
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Data can't be insert");
            }
        }

        public static void InsertDataLedger(Ledger ledger)
        {
            //inserts the data into Ledger
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Insert into Ledger (idle, idc, contraLedger, debitValue, creditValue, referenceNumber,date ) values ('" + ledger.IDLE + "', '" + ledger.IDC + "', '" + ledger.ContraLedger + "', '" + ledger.DebitValue + "','" + ledger.CreditValue + "','" + ledger.ReferenceNumber + "','" + ledger.Date +  "');";
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Data can't be insert");
            }
        }







        public static void SaveIDL(TextBox tb_username)
        {
            //selects the IDL from the table and saves it into the var IDL
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select IDL from login  where username = '" + tb_username.Text + "'";
            frm_login.IDL = cmd.ExecuteScalar().ToString();
            con.Close();
        }

        public static void SaveRole(TextBox tb_username)
        {
            //selects the Role from the table and saves it into the var role
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select role from login  where username = '" + tb_username.Text + "'";
            frm_login.role = cmd.ExecuteScalar().ToString();
            con.Close();
        }


        public static string SaveSQ1_Question(string IDL)
        {
            //selects the Sq1 question from the table
            string sq1_question;
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select sq1question from login  where IDL = '" + IDL + "'";
            sq1_question = cmd.ExecuteScalar().ToString();
            con.Close();
            return sq1_question;
        }

        public static string SaveSQ1(string IDL)
        {
            //selects the Sq1 from the table
            string sq1;
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select sq1 from login  where IDL = '" + IDL + "'";
            sq1 = cmd.ExecuteScalar().ToString();
            con.Close();
            return sq1;
        }

        public static string SaveSQ2_Question(string IDL)
        {
            //selects the Sq3 question from the table
            string sq2_question;
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select sq2question from login  where IDL = '" + IDL + "'";
            sq2_question = cmd.ExecuteScalar().ToString();
            con.Close();
            return sq2_question;
        }

        public static string SaveSQ2(string IDL)
        {
            //selects the Sq2 from the table
            string sq2;
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select sq2 from login  where IDL = '" + IDL + "'";
            sq2 = cmd.ExecuteScalar().ToString();
            con.Close();
            return sq2;
        }

        public static void ChangePassword(string password, string IDL)
        {
            //trys to change the old password to the new
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE LOGIN SET password = '" + password + "' where IDL = " + IDL;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Password can't be changed");
            }
        }

        #region Ledger

            public static void InsertDataAllLedgers(AllLedgers allledgers)
            {
                //inserts the data into LOGIN
                try
                {
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "Insert into AllLedgers (idc, number, name, type) values ('"+allledgers.IDC+"', '" + allledgers.Number + "', '" + allledgers.Name + "', '"+allledgers.Type+"');";
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Data can not be insert");
                }
            }

            public static bool ProofLedger(TextBox number)
            {
                //proofs if the user exists or not
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select number from AllLedgers";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (number.Text == dr["number"].ToString())
                    {
                        con.Close();
                        return true;
                    }
                }
                con.Close();
                return false;
            }

        public static int SaveIDLE(int number, int idc)
            {
                //selects the Sq2 from the table
                int idle;
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select IDLE from AllLedgers where number = '" + number + "' and IDC = '"+idc+"'";
                idle = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                con.Close();
                return idle;
            }

        

        #endregion

        #region Main

        public static void GetLedger(ComboBox cb)
        {
            //Get the DataBases
            cb.Items.Clear();
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select number from AllLedgers";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr[0]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }

        #endregion

    }
}
