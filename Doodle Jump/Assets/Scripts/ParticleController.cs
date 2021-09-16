using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    private int time = 5;

    private void Start() {
        Destroy(this.gameObject, time);    
    }
}
