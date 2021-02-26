using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody playerBody;
    public float forwardForce = 500f;
    public float sidewaysForce = 500f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //playerBody.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            //playerBody.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            playerBody.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
        {
            playerBody.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
   
        }
        if(Input.GetKey("w"))
        {
            playerBody.AddForce(0,0, forwardForce);
        }
        if(playerBody.position.y < -10)
        {
            FindObjectOfType<Manage>().EndGame();
        }
    }
}
