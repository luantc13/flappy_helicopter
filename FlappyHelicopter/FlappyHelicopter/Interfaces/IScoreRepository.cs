using FlappyHelicopter.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FlappyHelicopter.Interfaces
{
    public interface IScoreRepository
    {
        ObservableCollection<Score> Gets();
        bool Insert(Score score);
    }
}
