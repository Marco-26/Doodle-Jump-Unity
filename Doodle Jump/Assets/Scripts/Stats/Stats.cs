using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Stats : ScriptableObject
{
    public float score;     // use to see if current score is best than previous highscore
    public float highscore; // use to track best score
}
