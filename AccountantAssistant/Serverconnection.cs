using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Console;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace AccountantAssistant
{
    class Serverconnection
    {
        public static MySqlConnection con = new MySqlConnection("server=50.7.115.30;port=3306;user id=andi;password=Ny8r4yiJ!;persistsecurityinfo=True;database=ACAS_1;allowuservariables=True");
        public static MySqlCommand cmd = new MySqlCommand();
        public static MySqlDataReader dr;

        public static DataTable dt = new DataTable();
        public static DataTable dt1 = new DataTable();

        private static MySqlDataAdapter Da = new MySqlDataAdapter();
        private static MySqlCommandBuilder cmdbuilder = new MySqlCommandBuilder(Da);


        #region Login

        public static void Tryconnect() 
        {
            //trys to connect to the server and creates the tables and the database if it they are not avaialable
            try
            {
                con.Open();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "connection to server failed");
                con.Close();
            }
        }


        public static bool Proofuser(TextBox username)
        {
            //proofs if the user exists or not
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select username from Login";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (username.Text.Equals(dr["username"].ToString()))
                {
                    con.Close();
                    return true;
                }
            }
            con.Close();
            return false;
        }

        public static bool Proofpassword(TextBox tb_password, string username)
        {
            //Proof if the password matches with the user
            con.Open();
            cmd.Connection = con;
            string savedPassword = "";

            cmd.CommandText = "Select password from Login where username = '" + username + "'";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                savedPassword = dr["password"].ToString();
            }
            con.Close();

            bool isValidPassword = BCrypt.Net.BCrypt.Verify(tb_password.Text, savedPassword);
            if (isValidPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool PasswordQuery(TextBox tb_password, int IDL)
        {
            //Proof if the password matches with the user
            con.Open();
            cmd.Connection = con;
            string savedPassword = "";

            cmd.CommandText = "Select password from Login  where IDL = '" + IDL + "'";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                savedPassword = dr["password"].ToString();
            }
            con.Close();

            bool isValidPassword = BCrypt.Net.BCrypt.Verify(tb_password.Text, savedPassword);
            if (isValidPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void InsertDataLogin(Login login)
        {
            //inserts the data into LOGIN
            try
            {
                con.Open();
                cmd.Connection = con;
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(login.Password);
                cmd.CommandText = "Insert into Login (username, password, sq1, sq2, sq1question, sq2question, role ) values ('" + login.Username + "', '" + hashedPassword + "', '" + login.Sq1 + "', '" + login.Sq2 + "','" + login.Sq1question + "','" + login.Sq2question + "','" + login.Role + "');";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Data can not be insert");
            }
        }


        public static void SaveIDL(TextBox tb_username)
        {
            //selects the IDL from the table and saves it into the var IDL
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select IDL from Login where username = '" + tb_username.Text + "'";
            frm_login.IDL = cmd.ExecuteScalar().ToString();
            con.Close();
        }

        public static void SaveRole(TextBox tb_username)
        {
            //selects the Role from the table and saves it into the var role
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select role from Login where username = '" + tb_username.Text + "'";
            frm_login.role = cmd.ExecuteScalar().ToString();
            con.Close();
        }


        public static string SaveSQ1_Question(string IDL)
        {
            //selects the Sq1 question from the table
            string sq1_question;
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select sq1question from Login where IDL = '" + IDL + "'";
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
            cmd.CommandText = "Select sq1 from Login where IDL = '" + IDL + "'";
            sq1 = cmd.ExecuteScalar().ToString();
            con.Close();
            return sq1;
        }

        public static string SaveSQ2_Question(string IDL)
        {
            //selects the Sq2 question from the table
            string sq2_question;
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select sq2question from Login where IDL = '" + IDL + "'";
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
            cmd.CommandText = "Select sq2 from Login where IDL = '" + IDL + "'";
            sq2 = cmd.ExecuteScalar().ToString();
            con.Close();
            return sq2;
        }

        public static void SaveDarkmode(TextBox tb_username)
        {
            //selects the IDL from the table and saves it into the var IDL
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select darkmode from Login where username = '" + tb_username.Text + "'";
            if(Convert.ToInt32(cmd.ExecuteScalar()) == 0)
            {
                frm_settings.darkmode = false;
            }
            else
            {
                frm_settings.darkmode = true;
            }
            
            con.Close();
        }

        public static void ChangePassword(string password, string IDL)
        {
            //trys to change the old password to the new
            try
            {
                con.Open();
                cmd.Connection = con;
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
                cmd.CommandText = "UPDATE Login SET password = '" + hashedPassword + "' where IDL = " + IDL;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Password can't be changed");
            }
        }

        public static void ChangeDarkmode(int darkmode, string IDL)
        {
            //trys to change the darkmode settings of the user
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE Login SET darkmode = '" + darkmode + "' where IDL = " + IDL;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Password can't be changed");
            }
        }

        #endregion

        #region Ledger

        public static void InsertDataAllLedgers(AllLedgers allledgers)
            {
                //inserts the data into AllLedgers
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

            public static bool ProofLedger(TextBox number, int client)
            {
                //proofs if the Ledger exists or not
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select number from AllLedgers where IDC = '"+client +"' or IDC = 0";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (number.Text.Equals(dr["number"].ToString()))
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
                //selects the IDLE from the table
                int idle;
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select IDLE from AllLedgers where number = '" + number + "' and IDC = '"+idc+"' or IDC = 0";
                idle = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                con.Close();
                return idle;
            }

        

        #endregion

        #region Main

        public static void GetLedger(ComboBox cb, int client)
        {
            //Loads the Ledger of the client
            cb.Items.Clear();
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select number from AllLedgers where IDC = '"+client+"' or IDC = 0";
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

        public static void ShowLedgers(DataGridView dgv, int client)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select number, name, type from AllLedgers where IDC = '"+client+"' or IDC = 0";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dgv.Rows.Add(Convert.ToInt32(dr["number"]), dr["name"].ToString(), dr["type"].ToString());
            }
            con.Close();
        }

        public static void GetClient(ComboBox cb)
        {
            //Loads the Ledger of the client
            cb.Items.Clear();
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select IDC from Client";
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

        public static void InsertDataAccTransaction(AccTransaction accTransaction)
        {
            //inserts the data into AccTransaction
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Insert into AccTransaction (idc, ledger1, ledger2, netto, brutto, ust, salestaxrate, referenceNumber, date) values ('" + accTransaction.Idc + "', '" + accTransaction.Ledger1 + "', '" + accTransaction.Ledger2 + "', '" + accTransaction.Netto + "','" + accTransaction.Brutto + "','" + accTransaction.Ust + "','" + accTransaction.Salestaxrate + "','" + accTransaction.ReferenceNumber + "','" + accTransaction.Date + "');";
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
                cmd.CommandText = "Insert into Ledger (idle, idc, number, contraLedger, debitValue, creditValue, referenceNumber, date) values ('" + ledger.IDLE + "', '" + ledger.IDC + "', "+ledger.Number+", '" + ledger.ContraLedger + "', '" + ledger.DebitValue + "','" + ledger.CreditValue + "','" + ledger.ReferenceNumber + "','" + ledger.Date + "');";
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Data can't be insert");
            }
        }

        public static void InsertDataClient(Client client)
        {
            //inserts the data into Client
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Insert into Client (firstname, lastname, telephone, email, uidnumber, adress, plz , place , country) values ('" + client.Firstname + "', '" + client.Lastname + "', '" + client.Telephone + "', '" + client.Email + "','" + client.Uidnumber + "','" + client.Address + "','" + client.Plz + "','" + client.Place + "','" + client.Country + "');";
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Data can't be insert");
            }
        }

        public static string SaveType(int number, int idc)
        {
            //selects the IDLE from the table
            try
            {
                string type;
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select type from AllLedgers where number = '" + number + "' and IDC = '" + idc + "' or IDC = 0";
                type = cmd.ExecuteScalar().ToString();
                con.Close();
                return type;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Data can't be insert");
                con.Close();
                return null;
            }
        }

        #endregion

        #region Search

        public static void Search_refNumber(string search_item, DataGridView dgv, int idc)
        {
            //search for refNumber
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select date, referenceNumber, ledger1, ledger2, netto, brutto from AccTransaction where referenceNumber = '"+search_item +"'and IDC = '"+idc + "'";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dgv.Rows.Add(dr["date"].ToString(), dr["referenceNumber"].ToString(), Convert.ToInt32(dr["ledger1"]), Convert.ToInt32(dr["ledger2"]), Convert.ToDecimal(dr["netto"]), Convert.ToDecimal(dr["brutto"]));
            }
            con.Close();
       
        }


        

        public static void Search_Date(string search_date, DataGridView dgv, int idc)
        {
            string type = null;
            int number = 0;
            //search for Date
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select ledger1 from AccTransaction where date = '" + search_date + "'and IDC = '" + idc + "'";

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                number = Convert.ToInt32(dr["ledger1"]);
                
            }
            con.Close();

            type = Serverconnection.SaveType(number, idc);

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select date, referenceNumber, ledger1,  netto, ledger2, brutto from AccTransaction where date = '" + search_date + "'and IDC = '" + idc + "'";
            
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (type == "AB" || type == "AK")
                {
                    dgv.Rows.Add(dr["date"].ToString(), dr["referenceNumber"].ToString(), Convert.ToInt32(dr["ledger1"]), Convert.ToInt32(dr["ledger2"]), Convert.ToDecimal(dr["netto"]), 0);
                }
                else if (type == "PB" || type == "EK")
                {
                    dgv.Rows.Add(dr["date"].ToString(), dr["referenceNumber"].ToString(), Convert.ToInt32(dr["ledger1"]), Convert.ToInt32(dr["ledger2"]), 0, Convert.ToDecimal(dr["brutto"]));
                }
                else
                {
                    MessageBox.Show("Es ist ein Fehler passiert");
                }
            }
            con.Close();
        }



        public static void Search_ledger(int search_ledger, DataGridView dgv, int idc)
        {
            //search for ledger
            string type = Serverconnection.SaveType(search_ledger, idc);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select date, referenceNumber, ledger1, ledger2, netto, brutto from AccTransaction where ledger1 = '" + search_ledger + "'and IDC = '" + idc + "'";
            dr = cmd.ExecuteReader();
           
            while (dr.Read())
            {
                if (type == "AB" || type == "AK")
                {
                    dgv.Rows.Add(dr["date"].ToString(), dr["referenceNumber"].ToString(), Convert.ToInt32(dr["ledger1"]), Convert.ToInt32(dr["ledger2"]), Convert.ToDecimal(dr["netto"]), 0);
                }
                else if(type == "PB" || type == "EK")
                {
                    dgv.Rows.Add(dr["date"].ToString(), dr["referenceNumber"].ToString(), Convert.ToInt32(dr["ledger1"]), Convert.ToInt32(dr["ledger2"]),0, Convert.ToDecimal(dr["brutto"]));
                }
                else
                {
                    MessageBox.Show("Es ist ein Fehler passiert");
                }

                
            }
            con.Close();

        }

        #endregion

        #region Balance

        public static bool Balance(DataGridView dgv)
        {
            decimal saldo;
            con.Open();
            cmd.Connection = con;
            //cmd.CommandText = "Select  AllLedgers.number, AllLedgers.name, Ledger.creditValue, Ledger.debitValue from AllLedgers inner join Ledger on AllLedgers.IDLE = Ledger.IDLE ";
            cmd.CommandText = "Select AllLedgers.number, AllLedgers.name, SUM(Ledger.creditValue) as credit, SUM(Ledger.debitValue) as debit from AllLedgers inner join Ledger on AllLedgers.IDLE = Ledger.IDLE group by AllLedgers.number, AllLedgers.name";

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if(Convert.ToDecimal(dr["debit"]) > Convert.ToDecimal(dr["credit"]))
                {
                    saldo = Convert.ToDecimal(dr["debit"]) - Convert.ToDecimal(dr["credit"]);
                }
                else
                {
                    saldo = Convert.ToDecimal(dr["credit"]) - Convert.ToDecimal(dr["debit"]);
                }
                //dgv.Rows.Add(dr["number"].ToString(), dr["name"].ToString(), Convert.ToDecimal(dr["debitValue"]), Convert.ToDecimal(dr["creditValue"]));
                dgv.Rows.Add(dr["number"].ToString(), dr["name"].ToString(), Convert.ToDecimal(dr["debit"]), Convert.ToDecimal(dr["credit"]), saldo);

            }
            con.Close();
            return false;
        }


        #endregion
          
        #region Delete & Save


        public static void DeleteData(DataGridView dgv)
        {
            //Deletes the Row which is selected
            try
            {
                con.Open();
                dgv.Rows.RemoveAt(dgv.CurrentRow.Index);
                Da.Update(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }

        public static void SaveData()
        {
            //saves the data in the datagridview
            try
            {
                con.Open();
                Da.UpdateCommand = cmdbuilder.GetUpdateCommand();
                Da.Update(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }


        public static string datetimeCancel;
        public static string referenceNumberCancel;
        public static string contraLedgerCancel;
        public static string nettoCancel;
        public static string salestaxrateCancel;
        public static string ledgerCancel;

        public static void CancelTransaction(DataGridView dgv)
        {
            con.Open();

            //datetimeCancel = dgv.CurrentRow.Cells[0].Value.ToString();
            
            referenceNumberCancel = dgv.CurrentRow.Cells[1].Value.ToString();
            contraLedgerCancel = dgv.CurrentRow.Cells[2].Value.ToString();
            ledgerCancel = dgv.CurrentRow.Cells[3].Value.ToString();
            nettoCancel = dgv.CurrentRow.Cells[4].Value.ToString();
            salestaxrateCancel = dgv.CurrentRow.Cells[5].Value.ToString();

        }

        #endregion

    }
}
