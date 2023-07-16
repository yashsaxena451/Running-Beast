using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce = 100f;
    public float sidewardforce = 500f;
    
    void Update()
    {
            rb.AddForce(0, 0, forwardforce*Time.deltaTime);
        if(Input.GetKey("a"))
            {
            rb.AddForce(-sidewardforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewardforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y<-1f)
        {
            FindObjectOfType<Game_Manager>().Endgame();
        }

    }
}
