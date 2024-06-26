using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class FloppyScript : MonoBehaviour
{
    public Rigidbody2D floppyRigidBody;

    public GameObject floppy;
    public float wingPower = 20;
    public LogicScript logic;
    public bool floppyIsAlive = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update() 
    { 
        if (floppy.transform.position.x < -33 || floppy.transform.position.x > 33 || floppy.transform.position.y < -20)
        {
            floppyIsAlive = false;
            logic.GameOver();
        }
        if (Input.GetKeyDown(KeyCode.Space) == true && floppyIsAlive == true)
        {
            floppyRigidBody.velocity = Vector2.up * wingPower;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        floppyIsAlive = false;
        logic.GameOver();
    }
}
