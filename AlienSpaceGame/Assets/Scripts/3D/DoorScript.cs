using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    public GameObject door;
    private bool opening;
    public Vector3 startPos;
    public Vector3 endPos;

	// Use this for initialization
	void Start ()
    {
        opening = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        MoveDoor();
	}

    void MoveDoor()
    {
        //CHECKS IF DOOR IS OPENING OR CLOSING AND OPENS AND CLOSES
        switch(opening)
        {
            case true:
                door.transform.localPosition = Vector3.Lerp(door.transform.localPosition, endPos, 10f * Time.deltaTime);
                break;

            case false:
                door.transform.localPosition = Vector3.Lerp(door.transform.localPosition, startPos, 10f * Time.deltaTime);
                break;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        //WHEN YOOU ENTER TRIGGER IT OPENS THE DOOR
        if(other.gameObject.tag == "Player")
        {
            opening = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        //AND HERE IT CLOSES
        if(other.gameObject.tag == "Player")
        {
            opening = false;
        }
    }
}
