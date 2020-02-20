using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour, IPoolable
{
    public event System.Action OnDestroyEvent;

    private void OnDisable()
    {
        OnDestroyEvent();
    }
}
