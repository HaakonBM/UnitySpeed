using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public Rigidbody ballBody;
    private float forwardV = 50f;
    private float sidewaysV = 50f;

    public int moves = 10;
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
    private void OnCollisionEnter(Collision collision)
    {
        string collidedWith = collision.collider.tag;
        bool collTileBorder = collidedWith.StartsWith("tileBorder");
        if (collTileBorder)
        {
            Debug.Log("Went through TILEBORDER");
            if(moveVal())
            {
                move();
                Debug.Log("You have " + moves + " left");

            } else
            {
                Debug.Log("You have " + moves + " left, and are out of moves");
            }
        }
    }

    private void move ()
    {
        this.moves -= 1;
    }

    private bool moveVal()
    {
        if(moves > 0)
        {
            return true;
        }
        return false;
    }
}
