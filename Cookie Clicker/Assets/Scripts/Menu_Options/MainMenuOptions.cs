﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuOptions : MonoBehaviour {

    public static bool isLoading = false;

    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadGame()
    {
        isLoading = true;
        SceneManager.LoadScene(1);  
    }

    public void ExitGame()
    {
        Application.Quit();
    }
	
}
