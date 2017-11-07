using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Interact : MonoBehaviour {

    public int interaction;
    private LevelManager lmanager;

	void Start ()
    {
        lmanager = GameObject.Find("ScriptBlock").GetComponent<LevelManager>();
        interaction = 0;
	}

    public void InteractFunction()
    {
        switch(interaction)
        {
            case 0:
                lmanager.CallWaitTimes("SpaceShip");
                break;
            case 1:
                lmanager.CallWaitTimes("Planet");
                break;
            case 2:
                lmanager.CallWaitTimes("SpaceMenu");
                break;
        }
    }
}
