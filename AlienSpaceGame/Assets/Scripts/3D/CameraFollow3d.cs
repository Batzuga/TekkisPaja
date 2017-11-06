using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow3d : MonoBehaviour {

    private GameObject player;
    private Vector3 pp;
	// Use this for initialization
	void Start ()
    {
        player = GameObject.Find("Player3D");	
	}
	
	// Update is called once per frame
	void Update ()
    {
        pp = player.transform.position;
        //transform.position = new Vector3(pp.x + 10f, 16f, pp.z - 10f);
        transform.position = Vector3.Lerp(transform.position, new Vector3(pp.x + 10f, 16f, pp.z - 10f), 2f * Time.deltaTime);
	}
}
