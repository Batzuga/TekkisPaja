using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public string levelName;
    private Scene scene;

    void Awake()
    {
        //HAKEE LEVELIN NIMEN
        scene = SceneManager.GetActiveScene();
        levelName = scene.name;
    }

    public void ReloadLevel()
    {
        //LATAA TASON UUDESTAAN
        SceneManager.LoadScene(scene.name);
    }

    public void LoadOther(string s)
    {
        //LATAA HALUTUN KENTÄN f.e MENU tai SEURAAVA KENTTÄ
        SceneManager.LoadScene(s);
    }
}
