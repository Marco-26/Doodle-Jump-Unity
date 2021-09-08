using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public Spawn[] platforms;
    private Vector3 spawnpos = new Vector3(0, -3.676598f, 0);
    GameObject[] mPlatform;
    [SerializeField] PlayerController player;
    private float lastPlatform;

    void Start()
    {
        ManageDifficulty();
    }

    private void Update()
    {
        if (player.transform.position.y >= lastPlatform)
        {
            Debug.Log("Finish game");
        }
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
            // if loop is in first index, spawn the player at spawnpos cordinates with addition in y axis.
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
            if (a == 299)
            {
                lastPlatform = spawnpos.y;
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
