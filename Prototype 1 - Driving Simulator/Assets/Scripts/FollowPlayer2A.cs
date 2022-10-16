using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
