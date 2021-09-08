using UnityEngine;

public class StatsManager : MonoBehaviour
{
    public float score;
    public float highscore;
    [SerializeField] private Transform player;

    private void Start()
    {
        highscore = PlayerPrefs.GetFloat("highscore", 0);
    }

    private void Update()
    {   
        UpdateHighscore();
        Stats();
    }

    void UpdateHighscore()
    {
        // if the current score is bigger than the previous highscore, update the highscore
        if (this.score > highscore)
        {
            highscore = this.score;
            PlayerPrefs.SetFloat("highscore", highscore);
        }
    }

    void Stats()
    {
        // count current score
        if(player.position.y > score)
        {
            score = Mathf.Round(player.position.y);
        }
    }
}
