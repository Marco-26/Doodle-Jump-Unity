using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    [SerializeField] private Spawner spawner;
    [SerializeField]private enum state { normal, hard, infinite};
    [SerializeField]private state stateMachine;

    // user will choose the difficulty in main menu
    // this is the main logic begind this system
    void Start()
    {
        ManageDifficulty();
    }

    void ManageDifficulty()
    {
        // access spawner scripts and change variables acording to difficulty
        if(stateMachine == state.normal)
        {
            //do something
            spawner.platformCount = 300;
        }
        else if (stateMachine == state.hard)
        {
            //do something
            spawner.platformCount = 600;
        }
        else if(stateMachine == state.infinite)
        {
            //do something

        }
    }


}
