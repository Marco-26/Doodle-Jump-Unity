using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUIManager : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private Text highscoreText;
    [SerializeField] private StatsManager stats;

    private void Update()
    {
        // display score in screen
        scoreText.text = stats.score.ToString() + " POINTS";
        // display highscore in screen
        highscoreText.text = "Highscore: " + stats.highscore.ToString();
    }
}
