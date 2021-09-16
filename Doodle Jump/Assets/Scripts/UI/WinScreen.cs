using UnityEngine;

public class WinScreen : MonoBehaviour
{
    [SerializeField] private GameObject winScreen;
    [SerializeField] private PlayerController playerController;

    void Start(){ winScreen.SetActive(false); }
    public void ShowScreen() { winScreen.SetActive(true); playerController.DisablePlayer(); }

    // buttons

    public void PlayAgain() { FindObjectOfType<GameManager>().LoadLevel();}
    public void Quit() { Application.Quit(); }

    private void Update() {
        // disable pause menu script if win screen is active
        if(winScreen.activeInHierarchy){
            FindObjectOfType<PauseMenu>().enabled = false;
        }
    }

}
