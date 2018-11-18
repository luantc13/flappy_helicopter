using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlappyHelicopter.Models
{
    public class Score
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int Value { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
