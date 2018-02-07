using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfLevel : MonoBehaviour {

    private string scene;
    private AudioSource audio;
    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("scene01"))
            scene = "scene02";
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("scene02"))
            scene = "scene03";
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("scene03"))
            scene = "scene04";
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("scene04"))
            scene = "scene05";
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("scene05"))
            scene = "scene06";


    }

    /* end of level */
    private void EndScene()
    {
        SceneManager.LoadScene(scene);
    }

    
    private void OnTriggerEnter(Collider other)
    {
        audio.Play();
        Invoke("EndScene",0.2f);
        
    }

  
}
