using FlappyHelicopter.Helpers;
using FlappyHelicopter.Interfaces;
using FlappyHelicopter.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace FlappyHelicopter.Repositories
{
    public class ScoreRepository : IScoreRepository
    {
        Database db;

        public ScoreRepository()
        {
            db = new Database();
        }

        public ObservableCollection<Score> Gets()
        {
            List<Score> scores = db.Gets().OrderByDescending(s => s.Value).Take(5).ToList();
            return new ObservableCollection<Score>(scores);
        }

        public bool Insert(Score score)
        {
            return db.Insert(score);
        }
    }
}
