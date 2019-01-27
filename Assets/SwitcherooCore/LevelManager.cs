using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Grandma;


public class LevelManager : GrandmaComponent
{
    public static LevelManager Instance { get; private set; }

    public int currentLevel;

    public Damageable player;


    protected override void Start()
    {
        base.Start();
        Instance = this;
        player.OnDestroyed += Reload;
    }

    public void Reload()
    {
        SceneManager.LoadScene(currentLevel);
    }

    public void NextLevel()
    {
        currentLevel++;
        SceneManager.LoadScene(currentLevel);
    }

}
