using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheel4move : MonoBehaviour
{
    public Rigidbody ballBody;
    public float forwardV = 10f;
    public float sidewaysV = 10f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            Debug.Log("w pressd");
            ballBody.AddForce(0, 0, forwardV * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            ballBody.AddForce(0, 0, -forwardV * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            ballBody.AddForce(sidewaysV * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            ballBody.AddForce(-sidewaysV * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
