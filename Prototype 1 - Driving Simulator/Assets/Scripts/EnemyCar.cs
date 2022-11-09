using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 2022-11-08 - RETROALIMENTACIÓN DE CHRISTIAN
// Buen funcionamiento de script.
// Sería más apropiado un nombre como "MoveForward.cs".

public class EnemyCar : MonoBehaviour{

    public float enemySpeed = 20.0f;
    void Update(){
        transform.Translate(Vector3.forward * Time.deltaTime * enemySpeed);
    }
}
