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
        public const int MAX_NAME_LENGTH = 30;
         
        Database()
        {
            connectToDatabase(); 
            //Comment out below if not testing// 
            //addAthletes();
            //printAthletes();
        } 

        private void connectToDatabase() 
        { 
            string dBPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), DB_NAME);
            db = new SQLiteConnection(dBPath);
        } 

        public void addAthlete(String name)
        {
            var newAthlete = new Athlete();
            newAthlete.Name = name;
            db.Insert(newAthlete);
        } 

        //public Athlete getAthlete(String name)
        //{
        //    var existingItem = db.Get<Athlete>(name);
        //}

        [Table("Athletes")]
        private class Athlete
        {
            //[PrimaryKey, AutoIncrement, Column("_id")]
            //public int Id { get; set; }
            [PrimaryKey, MaxLength(MAX_NAME_LENGTH)]
            public string Name { get; set; }
        }   

           
        /////////////////////////////////////////////////////////////TEST METHODS////////////////////////////////////////////////////////// 

        ///Test Add/// 
        public void addAthletes()
        {
            if(db.Table<Athlete>().Count() == 0)
            {
                var newAthlete = new Athlete();
                newAthlete.Name = "Bob";
                db.Insert(newAthlete);
                newAthlete = new Athlete();
                newAthlete.Name = "Jill";
                db.Insert(newAthlete);
            }
        } 

        ///Test Print/// 
        public void printAthletes() 
        {
            Console.WriteLine("Reading data");
            var table = db.Table<Athlete>(); 
            foreach(var a in table)
            {
                Console.WriteLine(a.Name);
            }
        }
        
    }

    

  
}