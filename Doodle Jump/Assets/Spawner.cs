using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject platform;
    private int platformCount = 300;

    private void Start()
    {
        Vector3 spawnpos = new Vector3();
        for (int i = 0; i < platformCount; i++)
        {
            spawnpos.y += Random.Range(2f, 3f);
            spawnpos.x = Random.Range(-5f, 5f);
            Instantiate(platform, spawnpos, Quaternion.identity);
        }
    }
}
