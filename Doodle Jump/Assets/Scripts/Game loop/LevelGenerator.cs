using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public Spawn[] platforms;
    public int platformCount;
    private Vector3 spawnpos = new Vector3();
    //[SerializeField] private MovingPlatform movingPlat;
    GameObject[] mPlatform;

    void Start()
    {
        mPlatform = GameObject.FindGameObjectsWithTag("MovingPlatform");
        for (int i = 0; i < mPlatform.Length; i++)
        {
            //create bool to know if game is normal or hard, and change variables here.
            mPlatform[i].GetComponent<MovingPlatform>();
        }

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
            //less platforms and moving platform speed is lower
            platformCount = 300;
            //movingPlat.speed = 3;
        }
        else if (GameValues.difficulty == GameValues.Difficulties.hard)
        {
            //more platforms and moving platform speed is higher
            platformCount = 600;
            //movingPlat.speed = 9;
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
                spawnpos.x = Random.Range(-5.1f, 5.1f);
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
