using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls3d : MonoBehaviour {

    //JUMP VARIABLES
    private bool canJump;
    private bool jumpUnlocked;
    private float jumpPower;
    private float airControl;
    //MOVEMENT VARIABLES
    private float movementSpeed;
    private float baseSpeed;


    private Rigidbody rb;

    void Awake()
    {
        //GETS COMPONENTS
        rb = GetComponent<Rigidbody>();
    }

    void Start ()
    {
        //SETS START VALUES
        canJump = true;
        jumpUnlocked = true; //DEBUG VALUE
        jumpPower = 300f;
        airControl = 1f;
        baseSpeed = 5f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Move();
	}

    void Move()
    {
        //SETS MOVEMENT SPEED
        movementSpeed = airControl * baseSpeed;
        //MOVES THE CHARACTER VIA JOYSTICK
    }
    public void Jump()
    {
        if(canJump && jumpUnlocked)
        {
            canJump = false;
            rb.AddForce(Vector3.up * jumpPower);
            airControl = 0.25f;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Ground")
        {
            canJump = true;
            airControl = 1f;
        }
    }
}
