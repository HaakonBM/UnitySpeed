
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;




    void OnCollisionEnter(Collision colInfo)
    {
       
        string colidedName = colInfo.collider.tag;
        bool colidedWithObstacle = colidedName.StartsWith("Obstacle");

        if (colidedWithObstacle)
        {
            movement.enabled = false;
        }

    }
}
