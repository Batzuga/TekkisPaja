using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour {

    private StarManager starManager;
    private SoundManager soundManager;


    void Awake()
    {
        starManager = GameObject.Find("ScriptBlock").GetComponent<StarManager>();
        soundManager = GameObject.Find("ScriptBlock").GetComponent<SoundManager>();
    }

    void OnColliderEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            soundManager.Play(0);
            starManager.AddStar();
        }
    }
}
