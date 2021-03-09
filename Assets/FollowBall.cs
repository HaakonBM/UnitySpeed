using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform playerBall;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = playerBall.position + offset;
    }
}
