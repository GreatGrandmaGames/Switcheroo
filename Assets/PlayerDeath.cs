using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Grandma;

public class PlayerDeath : MonoBehaviour
{
    public Damageable d;
    public PlayRandom audio;

    private void Awake()
    {
        d.OnDestroyed += () =>
        {
            audio.PlayRand();
        };
    }
}
