using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        StartCoroutine(SplashScreenTimer());	
	}

    void FirstTimeSetup()
    {
        if(PlayerPrefs.GetInt("FirstTime") == 0)
        {
            PlayerPrefs.SetInt("Sounds", 1);
            PlayerPrefs.SetInt("Music", 1);
            PlayerPrefs.SetInt("FirstTime", 1);
        }
    }
    IEnumerator SplashScreenTimer()
    {
        yield return new WaitForSeconds(1.5f);
        FirstTimeSetup();
        SceneManager.LoadScene(1);
    }
}
