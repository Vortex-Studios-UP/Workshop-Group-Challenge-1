using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{    
    private float speed = 20f;
    private float turnSpeed = 45f;
    private float horizontalInput;
    private float forwardInput;

    void Update()
    {
        //Moviendo el cochesito :D
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up,horizontalInput * turnSpeed * Time.deltaTime);

        if(transform.position.x <= -7){
            transform.position = new Vector3(-7, transform.position.y, transform.position.z);
        }
        if(transform.position.x >= 7){
            transform.position = new Vector3(7, transform.position.y, transform.position.z);
        }
        

    }
}
