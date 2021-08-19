using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public Spawn[] platforms;
    private Vector3 spawnpos = new Vector3();
    GameObject[] mPlatform;
    [SerializeField] PlayerController player;

    void Start()
    {
        ManageDifficulty();
    }

    void ManageDifficulty()
    {       
        // access spawner scripts and change variables according to difficulty
        if (GameValues.difficulty == GameValues.Difficulties.normal)
        {
            //Generate level based on difficulty
            GenerateLevel(300);

            //Find moving platforms
            mPlatform = GameObject.FindGameObjectsWithTag("MovingPlatform");

            //Get moving platforms script and change speed based on difficulty
            for (int i = 0; i < mPlatform.Length; i++)
            {
                mPlatform[i].GetComponent<MovingPlatform>().speed = 4;
            }
        }
        else if (GameValues.difficulty == GameValues.Difficulties.hard)
        {
            //Generate level based on difficulty
            GenerateLevel(600);

            //Find moving platforms
            mPlatform = GameObject.FindGameObjectsWithTag("MovingPlatform");

            //Get moving platforms script and change speed based on difficulty
            for (int i = 0; i < mPlatform.Length; i++)
            {
                mPlatform[i].GetComponent<MovingPlatform>().speed = 9;
            }
        }
    }

    private void GenerateLevel(int platformCount)
    {
        for (int a = 0; a < platformCount; a++)
        {
            // if loop is int first index, spawn the player at spawnpos cordinates with addition in y axis.
            if (a == 1) player.SpawnPlayer(spawnpos.x, spawnpos.y + 2f);

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
}

// class that contains the platforms to spawn
[System.Serializable]
public class Spawn
{
    public GameObject spawnObject;
    public int minProbability = 0;
    public int maxProbability = 100;
}
