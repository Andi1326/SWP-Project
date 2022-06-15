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
        #region SQL connection

        //var for the class ServerConnection
        public static MySqlConnection con = new MySqlConnection("server=50.7.115.30;port=3306;user id=andi;password=Ny8r4yiJ!;persistsecurityinfo=True;database=ACAS_1;allowuservariables=True");
        public static MySqlCommand cmd = new MySqlCommand();
        public static MySqlDataReader dr;

        public static DataTable dt = new DataTable();
        public static DataTable dt1 = new DataTable();

        private static MySqlDataAdapter Da = new MySqlDataAdapter();
        private static MySqlCommandBuilder cmdbuilder = new MySqlCommandBuilder(Da);

        public static string contraLedgerCancel;
        public static string nettoCancel;
        public static string ledgerCancel;
        public static string salestaxrateCancel;

        #endregion

        #region Login

        public static void Tryconnect() 
        {
            //trys to connect to the server, if not, shows the Exception
            try
            {
                con.Open();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Es konnte keine Verbindung zum Server hergestellt werden. Bitte starten Sie das Programm neu.", "Verbindung zum Server fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }


        public static bool Proofuser(TextBox username)
        {
            try
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
            catch
            {
                MessageBox.Show("Username konnte nicht überprüft werden. Bitte informieren Sie Ihren Administrator", "Username konnte nicht überprüft werden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return false;
            }
        }

        public static bool Proofpassword(TextBox tb_password, string username)
        {
            //Proof if the password matches with the user with the username
            try
            {
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
            catch
            {
                MessageBox.Show("Passwort konnte nicht überprüft werden. Bitte informieren Sie Ihren Administrator", "Password konnte nicht überprüft werden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return false;
            }
        }

        public static bool PasswordQuery(TextBox tb_password, int IDL)
        {
            //Proof if the password matches with the user with the IDL
            try
            {
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
            catch
            {
                MessageBox.Show("Passwort konnte nicht überprüft werden. Bitte informieren Sie Ihren Administrator", "Password konnte nicht überprüft werden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return false;
            }
        }

        public static void InsertDataLogin(Login login)
        {
            //inserts the data into table LOGIN
            try
            {
                con.Open();
                cmd.Connection = con;
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(login.Password);
                cmd.CommandText = "Insert into Login (username, password, sq1, sq2, sq1question, sq2question, role, darkmode) values ('" + login.Username + "', '" + hashedPassword + "', '" + login.Sq1 + "', '" + login.Sq2 + "','" + login.Sq1question + "','" + login.Sq2question + "','" + login.Role + "', '"+login.Darkmode +"');";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Die Daten für den Login konnten nicht gespeichert werden. Bitte informieren Sie Ihren Administrator", "Login konnte nicht gespeichert werden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }


        public static void SaveIDL(TextBox tb_username)
        {
            //selects the IDL from the table and saves it into the var IDL
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select IDL from Login where username = '" + tb_username.Text + "'";
                frm_login.IDL = cmd.ExecuteScalar().ToString();
                con.Close();
            }
            catch
            {
                MessageBox.Show("IDL konnte nicht gespeichert werden. Bitte informieren Sie Ihren Administrator", "IDL konnte nicht gespeichert werden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        public static void SaveRole(TextBox tb_username)
        {
            //selects the Role from the table and saves it into the var role
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select role from Login where username = '" + tb_username.Text + "'";
                frm_login.role = cmd.ExecuteScalar().ToString();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Rolle konnte nicht gespeichert werden. Bitte informieren Sie Ihren Administrator", "Rolle konnte nicht gespeichert werden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }


        public static string SaveSQ1_Question(string IDL)
        {
            //selects the Sq1 question from the table and saves it into the var sq1_question
            try
            {
                string sq1_question;
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select sq1question from Login where IDL = '" + IDL + "'";
                sq1_question = cmd.ExecuteScalar().ToString();
                con.Close();
                return sq1_question;
            }
            catch
            {
                MessageBox.Show("Sicherheitsfrage 1 konnte nicht gespeichert werden. Bitte informieren Sie Ihren Administrator", "Sicherheitsfrage 1 konnte nicht gespeichert werden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return null;
            }
        }

        public static string SaveSQ1(string IDL)
        {
            //selects the Sq1 from the table and saves it into the var sq1
            try
            {
                string sq1;
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select sq1 from Login where IDL = '" + IDL + "'";
                sq1 = cmd.ExecuteScalar().ToString();
                con.Close();
                return sq1;
            }
            catch
            {
                MessageBox.Show("Antwort für Sicherheitsfrage 1 konnte nicht gespeichert werden. Bitte informieren Sie Ihren Administrator", " Antwort für Sicherheitsfrage 1 konnte nicht gespeichert werden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return null;
            }
        }

        public static string SaveSQ2_Question(string IDL)
        {
            //selects the Sq2 question from the table and saves it into the var sq2_question
            try
            {
                string sq2_question;
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select sq2question from Login where IDL = '" + IDL + "'";
                sq2_question = cmd.ExecuteScalar().ToString();
                con.Close();
                return sq2_question;
            }
            catch
            {
                MessageBox.Show("Sicherheitsfrage 2 konnte nicht gespeichert werden. Bitte informieren Sie Ihren Administrator", "Sicherheitsfrage 2 konnte nicht gespeichert werden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return null;
            }
        }

        public static string SaveSQ2(string IDL)
        {
            //selects the Sq2 from the table and saves it into the var sq2
            try
            {
                string sq2;
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select sq2 from Login where IDL = '" + IDL + "'";
                sq2 = cmd.ExecuteScalar().ToString();
                con.Close();
                return sq2;
            }
            catch
            {
                MessageBox.Show("Antwort für Sicherheitsfrage 2 konnte nicht gespeichert werden. Bitte informieren Sie Ihren Administrator", " Antwort für Sicherheitsfrage 2 konnte nicht gespeichert werden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return null;
            }
        }

        public static void SaveDarkmode(TextBox tb_username)
        {
            //selects the darkmode from the table and saves it into the var darkmode if darkmode is activated or not
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select darkmode from Login where username = '" + tb_username.Text + "'";
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                {
                    frm_settings.darkmode = false;
                }
                else
                {
                    frm_settings.darkmode = true;
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Design Einstellung konnte nicht gespeichert werden. Bitte informieren Sie Ihren Administrator", "Design Einstellung konnte nicht gespeichert werden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
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
            catch
            {
                MessageBox.Show("Passwort konnte nicht geändert werden. Bitte informieren Sie Ihren Administrator", "Password konnte nicht geändert werden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
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
            catch
            {
                MessageBox.Show("Design Einstellung konnte nicht geändert werden. Bitte informieren Sie Ihren Administrator", "Design konnte nicht geändert werden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        #endregion

        #region Ledger

        public static void InsertDataAllLedgers(AllLedgers allledgers)
        {
            //inserts the data into table AllLedgers
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Insert into AllLedgers (idc, number, name, type) values ('"+allledgers.IDC+"', '" + allledgers.Number + "', '" + allledgers.Name + "', '"+allledgers.Type+"');";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Die Daten für den AllLedgers konnten nicht gespeichert werden. Bitte informieren Sie Ihren Administrator", "AllLedgers konnte nicht gespeichert werden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        public static bool ProofLedger(TextBox number, int client)
        {
            //proofs if the Ledger exists or not
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select number from AllLedgers where IDC = '" + client + "' or IDC = 0";
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
            catch
            {
                MessageBox.Show("Kontonummer konnte nicht überprüft werden. Bitte informieren Sie Ihren Administrator", "Kontonummer konnte nicht überprüft werden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return false;
            }
        }

        public static int SaveIDLE(int number, int idc)
        {
            //selects the IDLE from the table and saves it into the var idle
            try
            {
                int idle;
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select IDLE from AllLedgers where number = '" + number + "' and IDC = '" + idc + "' or IDC = 0";
                idle = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                con.Close();
                return idle;
            }
            catch
            {
                MessageBox.Show("IDLE konnte nicht gespeichert werden. Bitte informieren Sie Ihren Administrator", "IDLE konnte nicht gespeichert werden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return 0;
            }
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
            catch
            {
                MessageBox.Show("Kontonummer konnte nicht gespeichert werden. Bitte informieren Sie Ihren Administrator", "Kontonummer konnte nicht gespeichert werden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        public static void ShowLedgers(DataGridView dgv, int client)
        {
            //Selects the data of AllLedgers and save it into the DataGridView
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select number, name, type from AllLedgers where IDC = '" + client + "' or IDC = 0";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dgv.Rows.Add(Convert.ToInt32(dr["number"]), dr["name"].ToString(), dr["type"].ToString());
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Daten von AllLedgers konnte nicht gespeichert werden. Bitte informieren Sie Ihren Administrator", "AllLedgers konnte nicht gespeichert werden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        public static void GetClient(ComboBox cb)
        {
            //Loads the IDC of the client
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
            catch
            {
                MessageBox.Show("IDC konnte nicht gespeichert werden. Bitte informieren Sie Ihren Administrator", "IDC konnte nicht gespeichert werden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        public static void InsertDataAccTransaction(AccTransaction accTransaction)
        {
            //inserts the data into table AccTransaction
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Insert into AccTransaction (idc, ledger1, ledger2, netto, brutto, ust, salestaxrate, referenceNumber, date) values ('" + accTransaction.Idc + "', '" + accTransaction.Ledger1 + "', '" + accTransaction.Ledger2 + "', '" + accTransaction.Netto + "','" + accTransaction.Brutto + "','" + accTransaction.Ust + "','" + accTransaction.Salestaxrate + "','" + accTransaction.ReferenceNumber + "','" + accTransaction.Date + "');";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Die Daten für AccTransaction konnten nicht gespeichert werden. Bitte informieren Sie Ihren Administrator", "AccTransaction konnte nicht gespeichert werden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        public static void InsertDataLedger(Ledger ledger)
        {
            //inserts the data into table Ledger
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Insert into Ledger (idle, idc, number, contraLedger, debitValue, creditValue, referenceNumber, date) values ('" + ledger.IDLE + "', '" + ledger.IDC + "', "+ledger.Number+", '" + ledger.ContraLedger + "', '" + ledger.DebitValue + "','" + ledger.CreditValue + "','" + ledger.ReferenceNumber + "','" + ledger.Date + "');";
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch
            {
                MessageBox.Show("Die Daten für Ledger konnten nicht gespeichert werden. Bitte informieren Sie Ihren Administrator", "Ledger konnte nicht gespeichert werden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        public static void InsertDataClient(Client client)
        {
            //inserts the data into table Client
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Insert into Client (firstname, lastname, telephone, email, uidnumber, adress, plz , place , country) values ('" + client.Firstname + "', '" + client.Lastname + "', '" + client.Telephone + "', '" + client.Email + "','" + client.Uidnumber + "','" + client.Address + "','" + client.Plz + "','" + client.Place + "','" + client.Country + "');";
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch
            {
                MessageBox.Show("Die Daten für den Client konnten nicht gespeichert werden. Bitte informieren Sie Ihren Administrator", "Client konnte nicht gespeichert werden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        public static string SaveType(string number, int idc)
        {
            //selects the type from the table and returns the value of var type
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
            catch
            {
                MessageBox.Show("Kontotyp konnte nicht gespeichert werden. Bitte informieren Sie Ihren Administrator", "Kontotyp konnte nicht gespeichert werden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return null;
            }
        }

        #endregion

        #region Search

        public static void Search_refNumber(string search_item, DataGridView dgv, int idc)
        {
            //search for refNumber and saves the data of AccTransaction into the DataGridView
            try
            {
                string type = null;
                string number = "";

                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select ledger1 from AccTransaction where referenceNumber = '" + search_item + "'and IDC = '" + idc + "'";

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    number = dr["ledger1"].ToString();
                }
                con.Close();

                type = SaveType(number, idc);

                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select date, referenceNumber, ledger1, ledger2, netto, brutto, salestaxrate from AccTransaction where referenceNumber = '" + search_item + "'and IDC = '" + idc + "'";
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (type == "AB" || type == "AK")
                    {
                        dgv.Rows.Add(dr["date"].ToString(), dr["referenceNumber"].ToString(), Convert.ToInt32(dr["ledger1"]), Convert.ToInt32(dr["ledger2"]), Convert.ToDecimal(dr["netto"]), 0, Convert.ToInt32(dr["salestaxrate"]));
                    }
                    else if (type == "PB" || type == "EK")
                    {
                        dgv.Rows.Add(dr["date"].ToString(), dr["referenceNumber"].ToString(), Convert.ToInt32(dr["ledger1"]), Convert.ToInt32(dr["ledger2"]), 0, Convert.ToDecimal(dr["brutto"]), Convert.ToInt32(dr["salestaxrate"]));
                    }
                    else
                    {
                        MessageBox.Show("Es ist ein Fehler passiert");
                    }
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Suche nach der Belegnummer ist fehlgeschlagen. Bitte informieren Sie Ihren Administrator", "Suche nach der Belegnummer ist fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        public static void Search_Date(string search_date, DataGridView dgv, int idc)
        {
            //search for date and saves the data of AccTransaction into the DataGridView
            try
            {
                string type = null;
                string number = "";
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select ledger1 from AccTransaction where date = '" + search_date + "'and IDC = '" + idc + "'";

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    number = dr["ledger1"].ToString();
                }
                con.Close();

                type = SaveType(number, idc);

                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select date, referenceNumber, ledger1,  netto, ledger2, brutto, salestaxrate from AccTransaction where date = '" + search_date + "'and IDC = '" + idc + "'";

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (type == "AB" || type == "AK")
                    {
                        dgv.Rows.Add(dr["date"].ToString(), dr["referenceNumber"].ToString(), Convert.ToInt32(dr["ledger1"]), Convert.ToInt32(dr["ledger2"]), Convert.ToDecimal(dr["netto"]), 0, Convert.ToInt32(dr["salestaxrate"]));
                    }
                    else if (type == "PB" || type == "EK")
                    {
                        dgv.Rows.Add(dr["date"].ToString(), dr["referenceNumber"].ToString(), Convert.ToInt32(dr["ledger1"]), Convert.ToInt32(dr["ledger2"]), 0, Convert.ToDecimal(dr["brutto"]), Convert.ToInt32(dr["salestaxrate"]));
                    }
                    else
                    {
                        MessageBox.Show("Es ist ein Fehler passiert");
                    }
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Suche nach Datum ist fehlgeschlagen. Bitte informieren Sie Ihren Administrator", "Suche nach Datum ist fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        public static void Search_ledger(string search_ledger, DataGridView dgv, int idc)
        {
            //search for ledger and saves the data of AccTransaction into the DataGridView
            try
            {
                string type = SaveType(search_ledger, idc);
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select date, referenceNumber, ledger1, ledger2, netto, brutto, salestaxrate from AccTransaction where ledger1 = '" + search_ledger + "'and IDC = '" + idc + "'";
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (type == "AB" || type == "AK")
                    {
                        dgv.Rows.Add(dr["date"].ToString(), dr["referenceNumber"].ToString(), Convert.ToInt32(dr["ledger1"]), Convert.ToInt32(dr["ledger2"]), Convert.ToDecimal(dr["netto"]), 0, Convert.ToInt32(dr["salestaxrate"]));
                    }
                    else if (type == "PB" || type == "EK")
                    {
                        dgv.Rows.Add(dr["date"].ToString(), dr["referenceNumber"].ToString(), Convert.ToInt32(dr["ledger1"]), Convert.ToInt32(dr["ledger2"]), 0, Convert.ToDecimal(dr["brutto"]), Convert.ToInt32(dr["salestaxrate"]));
                    }
                    else
                    {
                        MessageBox.Show("Es ist ein Fehler passiert");
                    }
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Suche nach Kontotyp ist fehlgeschlagen. Bitte informieren Sie Ihren Administrator", "Suche nach Kontotyp ist fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        #endregion

        #region Balance

        public static bool Balance(DataGridView dgv)
        {
            //calculates the balance of the ledgers and saves it into the DataGridView
            try
            {
                decimal saldo;
                con.Open();
                cmd.Connection = con;

                cmd.CommandText = "Select number, SUM(creditValue) as credit, SUM(debitValue) as debit from Ledger group by number";

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (Convert.ToDecimal(dr["debit"]) > Convert.ToDecimal(dr["credit"]))
                    {
                        saldo = Convert.ToDecimal(dr["debit"]) - Convert.ToDecimal(dr["credit"]);
                    }
                    else
                    {
                        saldo = Convert.ToDecimal(dr["credit"]) - Convert.ToDecimal(dr["debit"]);
                    }
                    dgv.Rows.Add(dr["number"].ToString(), Convert.ToDecimal(dr["debit"]), Convert.ToDecimal(dr["credit"]), saldo);

                }
                con.Close();
                return false;
            }
            catch
            {
                MessageBox.Show("Die Daten für die Bilanz konnten nicht gespeichert werden. Bitte informieren Sie Ihren Administrator", "Bilanz-Daten konnten nicht gespeichert werden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return false;
            }
        }

        #endregion
          
        #region Cancel

        public static void GetDataCancel(DataGridView dgv)
        {
            contraLedgerCancel = dgv.CurrentRow.Cells[2].Value.ToString();
            ledgerCancel = dgv.CurrentRow.Cells[3].Value.ToString();
            nettoCancel = dgv.CurrentRow.Cells[4].Value.ToString();
            salestaxrateCancel = dgv.CurrentRow.Cells[6].Value.ToString();
        }

        #endregion

    }
}
