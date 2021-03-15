using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBrick : MonoBehaviour
{

    public Rigidbody brickBody;
    public float sidewaysV = 20f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("d"))
        {
            Debug.Log("d pressed");
            brickBody.AddForce(sidewaysV ,0 ,0, ForceMode.Force);
        }
        if (Input.GetKey("a"))
        {
            Debug.Log("a pressed");
            brickBody.AddForce(-sidewaysV , 0, 0, ForceMode.Force);
        }
        void OnCollisionEnter(Collision colInfo)
        {

            string colidedName = colInfo.collider.tag;
            bool colidedWithObstacle = colidedName.StartsWith("tileBorder");

            if (colidedWithObstacle)
            {
                brickBody.velocity = Vector3.zero;
            }

        }



    }
}
