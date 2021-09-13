using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public enum Scene {
        Menu,
        Level,
    }

    public void LoadLevel() {
        StartCoroutine(loader(Scene.Level, .5f));
    }

    public void LoadMenu() {
        StartCoroutine(loader(Scene.Menu, .5f));
    }

    public IEnumerator loader(Scene scene, float waitTime) {
        //add fade in out anim here
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(scene.ToString());
    }

}

