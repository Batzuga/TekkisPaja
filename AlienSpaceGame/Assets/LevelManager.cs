using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public string levelName;
    private Scene scene;

    void Awake()
    {
        scene = SceneManager.GetActiveScene();
        levelName = scene.name;
    }

    public void ReloadLevel()
    {
        SceneManager.LoadScene(scene.name);
    }

    public void LoadOther(string s)
    {
        SceneManager.LoadScene(s);
    }
}
