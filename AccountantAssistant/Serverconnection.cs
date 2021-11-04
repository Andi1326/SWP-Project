﻿using System;
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

                cmd.CommandText = "use [ACAS] if not exists(select * from sysobjects where name = 'Login') begin create table Login (username varchar(50) Identity(1,1) primary key, password varchar(50), sq1 varchar(50), sq2 varchar(50), sq1question varchar(50), sq2question varchar(50), role varchar(50))";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "use [ACAS] if not exists(select * from sysobjects where name = 'Client') begin create table Client (IDC int Identity(1,1) primary key, firstname varchar(50), lastname varchar(50), telephone varchar(50), eMail varchar(50), uidNumber varchar(50), adress varchar(50), plz varchar(50), place varchar(50),country varchar(50))";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "use [ACAS] if not exists(select * from sysobjects where name = 'Ledger') begin create table Ledger (IDL int Identity(1,1) primary key, IDC int, contraLedger int, debitValue decimal, creditValue decimal)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "use [ACAS] if not exists(select * from sysobjects where name = 'Transaction') begin create table Transaction (IDT int Identity(1,1) primary key, IDC int, ledger1 int, ledger2 int, netto decimal, brutto decimal, ust decimal, salestaxrate int)";
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
