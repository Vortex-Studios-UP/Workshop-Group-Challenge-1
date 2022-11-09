using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 25f; //Haciendolo private ya no se puede modificar ni ver la velocidad dentro de Unity
    private float turnSpeed = 60f;
    private float forwardInput;
    private float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical"); // Gets the vertical input from player
        horizontalInput = Input.GetAxis("Horizontal"); // Gets horizontal input from player
        // Move forward by 20 meters per second based on forward input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Move sideways by 45 meters per second based on horizontal input
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}