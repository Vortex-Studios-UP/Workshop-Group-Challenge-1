using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer1 : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 4, -1);

    void Start(){
        transform.position = new Vector3(0.66f,4.11f,-13.36f);
    }
  
    void LateUpdate(){
        transform.position = player.transform.position + offset;
    }
}
