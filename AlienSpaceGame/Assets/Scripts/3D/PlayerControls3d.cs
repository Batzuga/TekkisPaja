using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class PlayerControls3d : MonoBehaviour{

    //JUMP VARIABLES
    private bool canJump;
    private bool jumpUnlocked;
    private float jumpPower;
    private float airControl;

    //MOVEMENT VARIABLES
    public float movementSpeed;
    private float baseSpeed;
    public bool moving;
    public bool canMove;

    //ENERGY
    private float energy;
    private float maxEnergy;
    private float batteryGrade;
    
    //COMPONENTS
    private Rigidbody rb;
    private PlayerUI pui;



    void Awake()
    {
        //GETS COMPONENTS
        rb = GetComponent<Rigidbody>();
        pui = GameObject.Find("Canvas").GetComponent<PlayerUI>();

    }

    void Start ()
    {
        //SETS START VALUES
        canJump = true;
        canMove = true;
        jumpUnlocked = true; //DEBUG VALUE
        jumpPower = 350f;
        airControl = 1f;
        baseSpeed = 5f;
        maxEnergy = 100f;
        energy = 50f;
        pui.GetEnergy(energy);


	}
	
	// Update is called once per frame
	void Update ()
    {
        Movements();
	}

    void Movements()
    {
        //SETS MOVEMENT SPEED
        movementSpeed = airControl * baseSpeed;
        //REMOVES ENERGY IF MOVING
        if(moving)
        {
            energy -= 1 * Time.deltaTime;
            pui.GetEnergy(energy);
        }
       
    }


    public void Jump()
    {
        if(canJump && jumpUnlocked)
        {
            canJump = false;
            rb.AddForce(Vector3.up * jumpPower);
            airControl = 0.25f;
            energy -= 5;
            pui.GetEnergy(energy);
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


    void OnTriggerStay(Collider col)
    {
        if(col.gameObject.tag == "EnergyStation")
        {
            if(energy < maxEnergy)
            {
                energy += 3f * Time.deltaTime;              
            }
            if(energy > maxEnergy)
            {
                energy = maxEnergy;
            }
            pui.GetEnergy(energy);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "SpacePad")
        {
            pui.SetInteract(0);
        }
    }
    void OnTriggerExit(Collider col)
    {
        if(col.gameObject.tag == "SpacePad")
        {
            pui.HideInteract();
        }
    }
}
