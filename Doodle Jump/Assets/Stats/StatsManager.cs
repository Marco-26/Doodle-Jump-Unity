using UnityEngine;
using UnityEngine.UI;
using System;

public class StatsManager : MonoBehaviour
{
    public float score;
    [SerializeField]private Transform player;
    [SerializeField]private Stats stats;

    private void Update()
    {
        // score only counts upwards, never downwards
        if(player.transform.position.y > score)
        {
            // variable to calculate y axis
            score = player.position.y;            
        }
        stats.score = Mathf.Round(score);

        UpdateHighscore();
    }

    void UpdateHighscore()
    {
        // if the current score is bigger than the previous highscore, update the highscore
        if(stats.score > stats.highscore)
        {
            stats.highscore = stats.score;
        }
    }
}
