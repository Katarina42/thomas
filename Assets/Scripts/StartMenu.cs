using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
public class StartMenu : MonoBehaviour {

    private Component Pause;

    private void Start()
    {
        try
        {
            Pause = GameObject.FindGameObjectWithTag("MainCamera").GetComponent("OnPause");
        }
        catch (NullReferenceException ex) { }

    }

    public void GameStart()
    {
        if (Pause)
            Time.timeScale = 1f;

        SceneManager.LoadScene("scene01");
    }

    public void GameExit()
    {
        Application.Quit();
    }

    public void GameResume()
    {
        if (Pause)
        {
            Time.timeScale = 1f;
            SceneManager.UnloadScene("scene00");

        }
    }



}
