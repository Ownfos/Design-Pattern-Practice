using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Observer.Naive
{
    public class BoardGame
    {
        private int score;
        private ScoreUI scoreUI;
        private SoundPlayer soundPlayer;

        public BoardGame()
        {
            score = 0;
            scoreUI = new ScoreUI();
            soundPlayer = new SoundPlayer();
        }

        public void IncrementScore(int amount)
        {
            Console.WriteLine($"Incrementing score by {amount}");
            score += amount;
            scoreUI.UpdateUI(score);
            soundPlayer.PlaySoundEffect();
        }
    }
}
