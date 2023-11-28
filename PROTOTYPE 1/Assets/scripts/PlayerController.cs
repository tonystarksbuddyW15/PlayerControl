using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   public float speed = 5.0f;
    private float turnSpeed = 25;
   public float horizontalInput;
    private forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // This is where we get player input 
        horizontalInput = Input.GetAxis("Horizontal");
        fowardInput = Input.GetAxis("Vertical");
      // We move the vehicle foward 
     transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // We turn the vehicle 

       

    }

}