using System;

namespace Exercise_DelegatesAndSortGUI.Model
{
    public class Gamer
    {

        public int Id { get; set; }
        public string NickName { get; set; }
        public int HighScore { get; set; }

        public Gamer(int id, string nickName, int highScore)
        {
            Id = id;
            NickName = nickName;
            HighScore = highScore;
        }

        public override string ToString()
        {
            return $"{Id} {NickName} {HighScore}";
        }
    }
}
