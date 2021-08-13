using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject normalPlatform;
    public GameObject BigBouncePlatform;
    public GameObject fallingPlatform;
    public int platformCount;

    private void Start()
    {
        ManageDifficulty();
        Spawn();
    }

    void Spawn()
    {
        // spawn platforms
        Vector3 spawnpos = new Vector3();
        for (int i = 0; i < platformCount; i++)
        {
            var prob = Random.Range(1, 10);

            spawnpos.y += Random.Range(2.5f, 2.9f);
            spawnpos.x = Random.Range(-4.5f, 4.5f);

            if (prob > 2)
            {
                Instantiate(normalPlatform, spawnpos, Quaternion.identity);
            }
            else if (prob > 1)
            {
                Instantiate(BigBouncePlatform, spawnpos, Quaternion.identity);
            }
            else
            {
                Instantiate(fallingPlatform, spawnpos, Quaternion.identity);
            }
        }
    }

    // set difficulty
    void ManageDifficulty()
    {
        // access spawner scripts and change variables acording to difficulty
        if (GameValues.difficulty == GameValues.Difficulties.normal)
        {
            //do something
            platformCount = 300;
        }
        else if (GameValues.difficulty == GameValues.Difficulties.hard)
        {
            //do something
            platformCount = 600;
        }
    }
}
