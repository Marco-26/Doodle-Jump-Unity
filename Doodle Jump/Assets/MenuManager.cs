using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public void NormalButton()
    {
        GameValues.difficulty = GameValues.Difficulties.normal;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void HardButton()
    {
        GameValues.difficulty = GameValues.Difficulties.hard;        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
