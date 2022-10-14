using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCar : MonoBehaviour{

    public float enemySpeed = 20.0f;
    void Update(){
        transform.Translate(Vector3.forward * Time.deltaTime * enemySpeed);
    }
}
