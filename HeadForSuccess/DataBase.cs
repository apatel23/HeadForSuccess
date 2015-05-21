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
        private class Athlete
        {
            [PrimaryKey, AutoIncrement, Column("_id")]
            public int Id { get; set; }
            [MaxLength(MAX_NAME_LENGTH)]
            public string Name { get; set; }
        } 
           
        /////////////////////////////////////////////////////////////TEST METHODS////////////////////////////////////////////////////////// 

        ///Test Add/// 
        public void addAthletes()
        {
            if(db.Table<Athlete>().Count() == 0)
            {
                var newStock = new Athlete();
                newStock.Name = "Bob";
                db.Insert(newStock);
                newStock = new Athlete();
                newStock.Name = "Jill";
                db.Insert(newStock);
            }
        } 

        ///Test Print/// 
        public void printAthletes() 
        {
            Console.WriteLine("Reading data");
            var table = db.Table<Athlete>(); 
            foreach(var s in table)
            {
                Console.WriteLine(s.Id + " " + s.Name);
            }
        }
        
    }

    

  
}