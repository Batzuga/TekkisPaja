using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls2d : MonoBehaviour {

    private float speed;
    private float maxSpeed;
    private float minSpeed;
    private float rotationSpeed;

    private bool shipLaunched;

    private Rigidbody2D rb2d;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();    
    }
    void Start ()
    {
        shipLaunched = true;
        maxSpeed = 10f;
        minSpeed = 1f;
        rotationSpeed = .75f;
    }
	
	void Update ()
    {
        LaunchShip();
	}

    void LaunchShip()
    {
        if(shipLaunched)
        {
            speed = 6f;
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
       
    }

    void TouchControls()
    {

    }

    void OnTriggerStay2D(Collider2D col)
    {
        if(col.gameObject.tag == "Blackhole")
        {
            Vector3 vectorToTarget = col.transform.localPosition - transform.localPosition;
            float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
            Quaternion q = Quaternion.AngleAxis(angle - 90, Vector3.forward);
            transform.rotation = Quaternion.Lerp(transform.rotation, q, Time.deltaTime * rotationSpeed);
        }
        if(col.gameObject.tag == "Repeller")
        {
            Vector3 vectorToTarget = col.transform.localPosition - transform.localPosition;
            float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
            Quaternion q = Quaternion.AngleAxis(-(angle - 90), Vector3.forward);
            transform.rotation = Quaternion.Lerp(transform.rotation, q, Time.deltaTime * rotationSpeed);
        }
    }
}
