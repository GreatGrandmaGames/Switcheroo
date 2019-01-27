using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Grandma;

public class LevelEnd : Interactable
{
    protected override void OnTriggered(string triggeringID)
    {
        LevelManager.Instance.NextLevel();
    }
}
