using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public Rigidbody ballBody;
    private float forwardV = 50f;
    private float sidewaysV = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey("w"))
        {
            ballBody.AddForce(0,0,forwardV * Time.deltaTime, ForceMode.VelocityChange);
        }
        if(Input.GetKey("s"))
        {
            ballBody.AddForce(0, 0,-forwardV * Time.deltaTime, ForceMode.VelocityChange);
        }
        if(Input.GetKey("d"))
        {
            ballBody.AddForce(sidewaysV * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
        {
            ballBody.AddForce(-sidewaysV * Time.deltaTime, 0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("space"))
        {
            ballBody.AddForce(0, sidewaysV * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
    }
}
