using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    private bool isPaused = false;
    [SerializeField]private GameObject pauseMenu;

    private void Start() {
        pauseMenu.SetActive(false);
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (isPaused) {
                Resume();
            }
            else if (!isPaused) {
                Pause();
            }
        }
    }

    private void Resume() {
        isPaused = !isPaused;
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    private void Pause() {
        isPaused = !isPaused;
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }
}
