using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public Spawn[] platforms;
    private Vector3 spawnpos = new Vector3(0, -3.676598f, 0);
    [SerializeField] PlayerController player;
    private float lastPlatformPosition;
    private float platformCount;
    private bool allowedToPlay = true;

    private void Start() {
        platformCount = Random.Range(500, 1000);
        GenerateLevel(platformCount);
        Debug.Log(lastPlatformPosition);
    }

    private void Update()
    {
        if (player.transform.position.y >= lastPlatformPosition+2f) {
            if(allowedToPlay){
                SoundManager.PlaySound(SoundManager.Sound.win);
                allowedToPlay = false;
            }   
            FindObjectOfType<WinScreen>().ShowScreen(); // activate win screen
        }
    }

    private void GenerateLevel(float platformCount)
    {
        for (int a = 0; a < platformCount; a++) {
            // if loop is in first index, spawn the player at spawnpos cordinates with addition in y axis.
            if (a == 1) player.SpawnPlayer(spawnpos.x, spawnpos.y + 2f);

            // generate level based on probabilities
            int n = Random.Range(0, 100);

            for (int i = 0; i < platforms.Length; i++) {
                if (n >= platforms[i].minProbability && n <= platforms[i].maxProbability) {
                    spawnpos.y += Random.Range(2.5f, 2.9f);
                    spawnpos.x = Random.Range(-5.1f, 5.1f);
                    Instantiate(platforms[i].spawnObject, spawnpos, Quaternion.identity);
                }
            }
        }

        lastPlatformPosition = spawnpos.y;
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
