using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 2022-11-08 - RETROALIMENTACIÓN DE CHRISTIAN
// Script sin funcionalidad.
// Lo único que hace este script es poner la cámara en la posición de inicio, algo que se puede hacer fácilmente en el Inspector.
// La única razón por la que la cámara sí se mueve con el jugador es porque lo pusieron como hijo de él.

public class FollowPlayer : MonoBehaviour
{

    void Start(){
        transform.position = new Vector3(0.66f,4.11f,-13.36f);
    }
}
