using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private Text highscoreText;
    [SerializeField] private StatsManager stats;

    // game win
    [SerializeField] private GameObject winScreen;

    private void Start() {
        winScreen.SetActive(false);
    }

    private void Update()
    {
        // display score in screen
        scoreText.text = stats.score.ToString() + " POINTS";
        // display highscore in screen
        highscoreText.text = "Highscore: " + stats.highscore.ToString();
    }

    // win screen
    public void WinScreen() {
        winScreen.SetActive(true);
    }
}
