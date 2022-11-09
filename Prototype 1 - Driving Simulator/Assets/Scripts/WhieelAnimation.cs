using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 2022-11-08 - RETROALIMENTACIÓN DE CHRISTIAN
// Buen funcionamiento de script.
// ¡Esxcelente idea! Felicidades por ir más allá del reto y animar las ruedas. Definitivamente le añaden carácter a sus vehículos.
// Pueden borrar la función Start() si no la usan.

public class WhieelAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right,20f);
    }
}
