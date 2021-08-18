using UnityEngine;
using UnityEngine.UI;
using System;

public class StatsManager : MonoBehaviour
{
    public int score;
    [SerializeField]private Transform player;
    [SerializeField]private Stats stats;

    private void Update()
    {
        // simply update score, bcause all logic is being made in bounce script
        stats.score = score;

        UpdateHighscore();
    }

    void UpdateHighscore()
    {
        // if the current score is bigger than the previous highscore, update the highscore
        if(this.score > stats.highscore)
        {
            stats.highscore = this.score;
        }
    }
}
