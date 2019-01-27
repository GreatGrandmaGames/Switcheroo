using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Grandma;


public class LevelManager : GrandmaComponent
{
    public static LevelManager Instance { get; private set; }

    public int currentLevel;
    protected override void Start()
    {
        base.Start();
        Instance = this;
    }

    public void Reload()
    {
        SceneManager.LoadScene(currentLevel);
    }

}
