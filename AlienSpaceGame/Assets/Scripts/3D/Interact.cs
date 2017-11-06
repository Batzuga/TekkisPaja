using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Interact : MonoBehaviour {

    public int interaction;

	void Start ()
    {
        interaction = 0;
	}

    public void InteractFunction()
    {
        switch(interaction)
        {
            case 0:
                SceneManager.LoadScene("SpaceMenu");
                break;
        }
    }
}
