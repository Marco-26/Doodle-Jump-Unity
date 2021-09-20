using UnityEngine;

public class MainMenu : MonoBehaviour
{
    void Update()
    {
        StartGame();
    }

    void StartGame() {
        if (Input.anyKey) {
            FindObjectOfType<GameManager>().LoadLevel();
            SoundManager.PlaySound(SoundManager.Sound.menu);
            Destroy(this);
        }
    }
}
