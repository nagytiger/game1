using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

public class scriptcube2 : MonoBehaviour
{
    public Rigidbody gr ;
    public float forwardforce = 2000f;
    public float sidewayforce = 500f;



    // Start is called before the first frame update
   

    // Update is called once per frame
    void FixedUpdate ()
    {
        gr.AddForce(0, 0, forwardforce*Time.deltaTime);
        if (Input.GetKey("right"))
        {
            gr.AddForce(sidewayforce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("left"))
        {
            gr.AddForce(-sidewayforce * Time.deltaTime,0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            gr.AddForce(0, -sidewayforce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("up"))
        {
            gr.AddForce(0, 0, sidewayforce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("down"))
        {
            gr.AddForce(0, 0, -sidewayforce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (gr.position.y < 0) 
        {
            FindObjectOfType<gamemanager>().endgame();
        }
    }
}
