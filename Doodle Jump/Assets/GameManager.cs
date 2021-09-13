using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public enum Scene {
        Menu,
        Level,
    }

    [SerializeField] private Animator SceneTransitionsAnimator;

    public void LoadLevel() {
        StartCoroutine(loader(Scene.Level, 1f));
    }

    public void LoadMenu() {
        StartCoroutine(loader(Scene.Menu, 1f));
    }

    public IEnumerator loader(Scene scene, float waitTime) {
        //add fade in out anim here
        SceneTransitionsAnimator.SetTrigger("Start");
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(scene.ToString());
    }

}

