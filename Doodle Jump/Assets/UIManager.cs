using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private StatsManager stats;

    private void Update()
    {
        scoreText.text = Mathf.Round(stats.score).ToString();
    }
}
