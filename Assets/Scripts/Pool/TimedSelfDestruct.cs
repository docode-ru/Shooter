﻿using UnityEngine;
using System.Collections;

[AddComponentMenu("Playground/Gameplay/Timed Self-Destruct Pool")]
public class TimedSelfDestructPool : MonoBehaviour
{

    // After this time, the object will be destroyed
    public float timeToDestruction;


    void Start()
    {
        Invoke("DestroyMe", timeToDestruction);
    }


    // This function will destroy this object :(
    void DestroyMe()
    {
        Destroy(gameObject);

        // Bye bye!
    }
}
