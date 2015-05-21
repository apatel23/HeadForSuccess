using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Foundation;
using UIKit;
using SQLite;
using System.IO;

namespace HeadForSuccess
{
    public class Database{
   
        private SQLiteConnection db;
        private const String DB_NAME = "Database.sqlite"; 
        private const int MAX_NAME_LENGTH = 30;
         
        Database()
        {
            connectToDatabase(); 
            //Comment out below if not testing// 
            addAthletes();
            printAthletes();
        } 

        public void connectToDatabase() 
        { 
            string dBPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), DB_NAME);
            db = new SQLiteConnection(dBPath);
        }

        [Table("Athletes")]
        private class Stock
        {
            [PrimaryKey, AutoIncrement, Column("_id")]
            public int Id { get; set; }
            [MaxLength(MAX_NAME_LENGTH)]
            public string Name { get; set; }
        } 
         
        ///Test Add/// 
        public void addAthletes()
        {
            if(db.Table<Stock>().Count() == 0)
            {
                var newStock = new Stock();
                newStock.Name = "Bob";
                db.Insert(newStock);
                newStock = new Stock();
                newStock.Name = "Jill";
                db.Insert(newStock);
            }
        } 

        ///Test Print/// 
        public void printAthletes() 
        {
            Console.WriteLine("Reading data");
            var table = db.Table<Stock>(); 
            foreach(var s in table)
            {
                Console.WriteLine(s.Id + " " + s.Name);
            }
        }
        
    }

    

  
}