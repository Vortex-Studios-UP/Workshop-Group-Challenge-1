using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 2022-11-08 - RETROALIMENTACIÓN DE CHRISTIAN
// Buen funcionamiento de script.
// ¡Es muy impresionante que implementaron límites de movimiento! Felicidades.

public class PlayerControler : MonoBehaviour
{    
    private float speed = 20f;
    private float turnSpeed = 45f;
    private float horizontalInput;
    private float forwardInput;

    void Start(){
        transform.position = new Vector3(0.0f,0.0f,-3.21f);
    }

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
        if(transform.position.z <= -9){
            transform.position = new Vector3(transform.position.x, transform.position.y, -9);
        }
        if(transform.position.z >= 180){
            transform.position = new Vector3(transform.position.x, transform.position.y, 180);
        }
        

    }
}
