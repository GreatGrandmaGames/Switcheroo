using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Grandma;


public class LevelManager : GrandmaComponent
{
    public static LevelManager Instance { get; private set; }

    public string[] levelNames =
    {
        "1-1",
        "1-2",
        "1-3"
    };

    private int currentLevel = 0;

    public Damageable player;

    protected override void Start()
    {
        base.Start();
        Instance = this;
        player.OnDestroyed += Reload;
    }

    public void Reload()
    {
        SceneManager.LoadScene(levelNames[currentLevel], LoadSceneMode.Additive);
    }

    public void NextLevel()
    {
        SceneManager.UnloadSceneAsync(levelNames[currentLevel]);
        currentLevel++;
        SceneManager.LoadScene(levelNames[currentLevel], LoadSceneMode.Additive);
    }
}
