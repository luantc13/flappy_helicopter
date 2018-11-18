using FlappyHelicopter.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlappyHelicopter.Helpers
{
    public class Database
    {
        public string Folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

        public Database()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(Folder, "FlappyHelicopter.db")))
                {
                    connection.CreateTable<Score>();
                }
            }
            catch (SQLiteException ex)
            {
                //Log.Info("SQLiteEx", ex.Message);   
            }
        }

        public List<Score> Gets()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(Folder, "FlappyHelicopter.db")))
                {
                    return connection.Table<Score>().ToList();
                }
            }
            catch (SQLiteException ex)
            {
                return null;
            }
        }

        public bool Insert(Score score)
        {
            try
            {
                using (var connection = new
                    SQLiteConnection(System.IO.Path.Combine(Folder, "FlappyHelicopter.db")))
                {
                    connection.Insert(score);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                return false;
            }
        }
    }
}
