using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Grandma;

public class SnekDeath : MonoBehaviour
{
    public Damageable d;

    private void Start()
    {
        d.OnDestroyed += () =>
        {
            Destroy(d.gameObject);
        };
    }
}
