using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public void RestartGame() {
        StartCoroutine(RestartGameCO());
    }

    private IEnumerator RestartGameCO() {
        yield return new WaitForSeconds(.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GameWin() {
        // activate win screen
        SceneManager.LoadScene("Menu");
    }

}

