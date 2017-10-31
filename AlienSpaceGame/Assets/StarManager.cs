using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarManager : MonoBehaviour {

    private Text starText;
    private int starsCollected;
    private int totalStars;

    private LevelManager lvlManager;
    private string levelName;

	// Use this for initialization
	void Awake()
    {
        lvlManager = GameObject.Find("ScriptBlock").GetComponent<LevelManager>();
        levelName = lvlManager.levelName;
    }
    void Start()
    {

    }
    void SaveStars()
    {
        
    }

    public void AddStar()
    {

    }
}
