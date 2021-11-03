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

                cmd.CommandText = "use [ACAS] if not exists(select * from sysobjects where name = 'Login') begin create table Login (IDL int Identity(1,1) primary key, username varchar(50), password varchar(50), sq1 varchar(50), sq2 varchar(50), sq1question varchar(50), sq2question varchar(50)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "use [ACAS] if not exists(select * from sysobjects where name = 'Accountant') begin create table Customer (IDC int Identity(1,1) primary key, IDL int, firstname varchar(50), lastname varchar(50), place varchar(50), country varchar(50), email varchar(50), street varchar(50), plz varchar(8), company varchar(50)) end";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "use [ACAS] if not exists(select * from sysobjects where name = 'Booking') begin create table Booking (IDO int Identity(1,1) primary key, IDC int, Completed bit, Product varchar(50), Amount int, Price decimal(18,2), Totalprice decimal(18,2), Netto decimal(18,2), Brutto decimal(18,2), USt decimal(18,2)) end";
                cmd.ExecuteNonQuery();
                con.Close();






            }
            catch
            {

            }
        
        
        
        }





        //public static bool Proofuser(TextBox textBox)
        //{

        //}




    }
}
