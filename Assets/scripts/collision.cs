using UnityEngine;

public class collision : MonoBehaviour
{
    public scriptcube2 movment;
     void OnCollisionEnter ( Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "obs")
        {
           movment.forwardforce = movment.forwardforce + 50 ;
        }
    }
    
}
