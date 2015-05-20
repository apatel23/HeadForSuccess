using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Foundation;
using UIKit; 
using System.Data.SQLite;
using System.Data;

namespace HeadForSuccess
{

    class DataBase
    {
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            DataBase dB = new DataBase();
            Console.ReadLine();

        }

        static String DB_PATH = "/Data/";
        static String DB_NAME = "DataBase.sqlite";

        SQLiteConnection dataBase;

        DataBase()
        {
            createNewDataBase();
            //connectToDataBase();
            //createTable();
            fillTable();
            printNames();
        }

        void createNewDataBase()
        {
            dataBase = new SQLiteConnection("Data Source=" + DB_NAME + ";Version=3;");
            Boolean dbExist = existDataBase();

            if (!dbExist)
            {
                SQLiteConnection.CreateFile(DB_NAME);
                dataBase = new SQLiteConnection("Data Source=" + DB_NAME + ";Version=3;");
                dataBase.Open();
                createTable();
            }
            else
            {
                dataBase = new SQLiteConnection("Data Source=" + DB_NAME + ";Version=3;");
                dataBase.Open();
            }


        }

        public bool existDataBase()
        {
            Boolean checkDB = true;
            using (var connection = new SQLiteConnection(dataBase.ConnectionString))
            {
                try
                {
                    connection.Open();
                }
                catch (Exception)
                {
                    checkDB = false;
                }
            }

            return checkDB;
        }

        //void connectToDataBase()
        //{
        //    dataBase = new SQLiteConnection("Data Source=DataBase.sqlite;Version=3;");
        //    dataBase.Open();
        //} 

        void createTable()
        {
            string sql = "create table clients (name varechar(20))";
            SQLiteCommand command = new SQLiteCommand(sql, dataBase);
            command.ExecuteNonQuery();
        }

        void fillTable()
        {
            string sql = "insert into clients (name) values ('h')";
            SQLiteCommand command = new SQLiteCommand(sql, dataBase);
            command.ExecuteNonQuery();
            sql = "insert into clients (name) values ('t')";
            command = new SQLiteCommand(sql, dataBase);
            command.ExecuteNonQuery();
        }

        void printNames()
        {
            string sql = "select * from clients order by name asc";
            SQLiteCommand command = new SQLiteCommand(sql, dataBase);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                Console.WriteLine("Name: " + reader["name"]);
            Console.ReadLine();
        }

    }
}