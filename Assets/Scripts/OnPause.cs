using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnPause : MonoBehaviour {

    public bool IsPaused;

    void Update () {

        IsPaused = false;

        if (Input.GetKeyUp(KeyCode.Escape))
            IsPaused = true;

        PauseGame();
	}

    void PauseGame()
    {
        if (IsPaused)
        {
            Time.timeScale = 0f;
            SceneManager.LoadScene("scene00", LoadSceneMode.Additive);
        }

    }
}
