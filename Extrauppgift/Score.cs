using System;
namespace Extrauppgift
{
    class Score
    {
        private int score;
        private int maxScore;
        private void AddScore()
        {
            score++;
            maxScore++;

        }
        public void AddMaxScore()
        {
            maxScore++;
        }
        public int GetScore()
        {
            return score;
        }
        public int GetMaxScore()
            {
                return maxScore;
            }
        
    }
}