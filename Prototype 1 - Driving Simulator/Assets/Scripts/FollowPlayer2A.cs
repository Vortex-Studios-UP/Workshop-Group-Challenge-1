using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 2022-11-08 - RETROALIMENTACIÓN DE CHRISTIAN
// Buen funcionamiento de script pese a que no se usa.
// Mismos comentarios que en "FollowPlayer1.cs".
// No es necesario crear dos scripts cuando la única diferencia es la posición.

public class FollowPlayer2A : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 3, 0);

    void Start(){
        transform.position = new Vector3(174.0f,90.8f,70.02f);
    }
  
    void LateUpdate(){
        transform.position = player.transform.position + offset;
    }
}
