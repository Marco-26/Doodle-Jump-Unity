using UnityEngine;

public class WinScreen : MonoBehaviour
{
    [SerializeField] private GameObject winScreen;
    void Start(){ winScreen.SetActive(false); }
    public void ShowScreen() { winScreen.SetActive(true); }

    // buttons

    public void PlayAgain() { FindObjectOfType<GameManager>().LoadLevel(); }
    public void Quit() { Application.Quit(); }

}
