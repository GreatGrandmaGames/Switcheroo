﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaseLevel : MonoBehaviour
{
    private void Awake()
    {
        SceneManager.LoadScene("1-1", LoadSceneMode.Additive);
    }
}
