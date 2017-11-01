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

    private GameObject[] starsInScene;
	
	void Awake()
    {
        //HAKEE KOMPONENTIT
        lvlManager = GameObject.Find("ScriptBlock").GetComponent<LevelManager>();
    }
    void Start()
    {
        //HAKEE TASON NIMEN TALLENTAMISTA VARTEN
        levelName = lvlManager.levelName;
        starsInScene = GameObject.FindGameObjectsWithTag("Star");
        totalStars = starsInScene.Length;
    }

    void SaveStars()
    {
        
    }

    public void AddStar()
    {

    }
}
