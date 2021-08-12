using UnityEngine;
using UnityEngine.UI;
using System;

public class UIManager : MonoBehaviour
{
    [SerializeField]private Text scoreText;
    [SerializeField]private float score;
    [SerializeField]private Transform player;


    private void Update()
    {
        // score only counts upwards, never downwards
        if(player.transform.position.y > score)
            // variable to calculate y axis
            score = player.position.y;
        // update text with y axis of player
        scoreText.text = Mathf.Round(score).ToString();
    }
}
