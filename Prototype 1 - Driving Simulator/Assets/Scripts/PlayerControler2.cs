using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler2 : MonoBehaviour
{
    private float speed = 20f;
    private float turnSpeed = 45f;
    private float horizontalInput;
    private float forwardInput;

    void Start(){
        transform.position = new Vector3(-4.91f,0.0f,170.0f);
        transform.Rotate(0.0f,180.0f,0.0f);
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal2");
        forwardInput = Input.GetAxis("Vertical2");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up,horizontalInput * turnSpeed * Time.deltaTime);

        if(transform.position.x <= -7){
            transform.position = new Vector3(-7, transform.position.y, transform.position.z);
        }
        if(transform.position.x >= 7){
            transform.position = new Vector3(7, transform.position.y, transform.position.z);
        }
        if(transform.position.z <= -9){
            transform.position = new Vector3(transform.position.x, transform.position.y, -9);
        }
        if(transform.position.z >= 180){
            transform.position = new Vector3(transform.position.x, transform.position.y, 180);
        }
    }
}
