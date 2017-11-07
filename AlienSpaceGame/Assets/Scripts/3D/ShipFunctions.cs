using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipFunctions : MonoBehaviour {

    private int totalStars;
    private int batteryFound;

    public GameObject[] lamps;
    public Color[] lightColor;

	// Use this for initialization
	void Start ()
    {
        batteryFound = PlayerPrefs.GetInt("BatteryCollected");
        SetLights();	
	}
    
	void SetLights()
    {
        if(batteryFound == 1)
        {
            lamps[0].GetComponent<Light>().color = lightColor[1];
            lamps[1].GetComponent<Light>().color = lightColor[1];
            lamps[2].GetComponent<Light>().color = lightColor[1];
        }
        if(batteryFound == 0)
        {
            lamps[0].GetComponent<Light>().color = lightColor[0];
            lamps[1].GetComponent<Light>().color = lightColor[0];
            lamps[2].GetComponent<Light>().color = lightColor[0];
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
