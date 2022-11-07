using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveControl : MonoBehaviour
{

    public Rigidbody rb;

    public float editForwardForce = 500f;
    public float editSizeWayForce = 200f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, editForwardForce * Time.deltaTime);
        
        if(Input.GetKey("a")){
            rb.AddForce(-editSizeWayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

         if(Input.GetKey("d")){
            rb.AddForce(editSizeWayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
