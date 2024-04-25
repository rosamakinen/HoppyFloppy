using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class FloppyScript : MonoBehaviour
{
    public Rigidbody2D floppyRigidBody;
    public float wingPower = 15;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            floppyRigidBody.velocity = Vector2.up * wingPower;
        }
    }
}
