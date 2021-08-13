using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Spawn[] platforms;
    public int platformCount;
    private Vector3 spawnpos = new Vector3();

    void Start()
    {
        ManageDifficulty();
        for (int a = 0; a < platformCount; a++)
        {
            GenerateLevel();
        }
    }

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

    private void GenerateLevel()
    {
        // generate level based on probabilities
        int n = Random.Range(0, 100);

        for (int i = 0; i < platforms.Length; i++)
        {
            if (n >= platforms[i].minProbability && n <= platforms[i].maxProbability)
            {
                spawnpos.y += Random.Range(2.5f, 2.9f);
                spawnpos.x = Random.Range(-5.3f, 5.3f);
                Instantiate(platforms[i].spawnObject, spawnpos, Quaternion.identity);
            }
        }
    }
}

// class that contains the platforms to spawn
[System.Serializable]
public class Spawn
{
    public GameObject spawnObject;
    public int minProbability = 0;
    public int maxProbability = 100;

}
