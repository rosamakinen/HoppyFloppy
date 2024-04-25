using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class FloppyScript : MonoBehaviour
{
    public Rigidbody2D floppyRigidBody;
    public float wingPower = 22;
    public LogicScript logic;
    public bool floppyIsAlive = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && floppyIsAlive)
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
