using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

    private AudioSource audioSource;
    private int isMusicOn;

	void Awake ()
    {
        audioSource = GameObject.Find("Main Camera").GetComponent<AudioSource>();
        isMusicOn = PlayerPrefs.GetInt("Music");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
