using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Foundation;
using UIKit; 
using System.Data.SQLite; 
//using SQLite;

namespace HeadForSuccess
{  
    
    class DataBase
    {

        SQLiteConnection dataBase;  

        DataBase()
        {
            createNewDataBase();
            connectToDataBase();
        } 

        private void createNewDataBase()
        {
            SQLiteConnection.CreateFile("DataBase.sqlite"); 
        }

        private void connectToDataBase()
        {
            dataBase = new SQLiteConnection("Data Source=DataBase.sqlite;Version=3;");
            dataBase.Open();
        }   
         
        ////////////////////////////////////////////////////////////////TESTING METHODS//////////////////////////////////////////////////////

        // For Testing
        private void createTable()
        {
            string sql = "create table clients (name varechar(20))";
            SQLiteCommand command = new SQLiteCommand(sql, dataBase);
            command.ExecuteNonQuery();  
        } 
         
        // For Testing
        private void fillTable() 
        {
            string sql = "insert into clients (name) values ('Bob')";
            SQLiteCommand command = new SQLiteCommand(sql, dataBase);
            command.ExecuteNonQuery();
        } 
         
        // For Testing
        private void printNames()
        {
            string sql = "select * from clients order by name desc";
            SQLiteCommand command = new SQLiteCommand(sql, dataBase);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                Console.WriteLine("Name: " + reader["name"]);
            Console.ReadLine();
        }
    }
}