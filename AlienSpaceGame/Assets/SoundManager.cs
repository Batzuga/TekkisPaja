using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    private AudioSource audioSource;
    private AudioClip sCS; //Star Collect Sound

	// Use this for initialization
	void Awake ()
    {
        audioSource = GameObject.Find("ScriptBlock").GetComponent <AudioSource>();
	}
	
    
    public void Play(int i)
    {
        switch(i)
        {
            case 0:

                break; 
        }
    }
}
