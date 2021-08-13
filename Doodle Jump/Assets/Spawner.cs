using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // public GameObject normalPlatform;
    // public GameObject BigBouncePlatform;
    // public GameObject fallingPlatform;
    public Spawn[] platforms;
    private int platformCount = 300;

    // private void Start()
    // {
    //     Vector3 spawnpos = new Vector3();
    //     for (int i = 0; i < platformCount; i++)
    //     {
    //         var prob = Random.Range(1, 10);

    //         spawnpos.y += Random.Range(2.5f, 2.9f);
    //         spawnpos.x = Random.Range(-4.5f, 4.5f);

    //         if (prob > 2)
    //         {
    //             Instantiate(normalPlatform, spawnpos, Quaternion.identity);
    //         }
    //         else if (prob > 1)
    //         {
    //             Instantiate(BigBouncePlatform, spawnpos, Quaternion.identity);
    //         }
    //         else
    //         {
    //             Instantiate(fallingPlatform, spawnpos, Quaternion.identity);
    //         }
    //     }
    // }

    
    void Update()
    {
        GenerateLevel();
    }

    private void GenerateLevel(){
        int n = Random.Range(0,100);
        for(int i = 0; i < platforms.Length; i++){
            if(n >= platforms[i].minProbability && n <= platforms[i].maxProbability){
                Instantiate(platforms[i].spawnObject, transform.position, Quaternion.identity);
                break;
            }
        }
    }
}

[System.Serializable]
public class Spawn{
    public GameObject spawnObject;
    public int minProbability = 0;
    public int maxProbability = 100;

}
