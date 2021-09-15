using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private PauseMenu pauseMenu;

    public void Disable() { pauseMenu.enabled = false; }
    public void Enable() { pauseMenu.enabled = true; }

}
