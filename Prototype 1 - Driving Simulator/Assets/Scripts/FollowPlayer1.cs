using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 2022-11-08 - RETROALIMENTACIÓN DE CHRISTIAN
// Buen funcionamiento básico de script pese a que no está siendo usado.
// Como pusieron todas las cámaras como hijos de los jugadores, la posición y rotación de la cámara ya se actualiza automáticamente.

// La desventaja de hacer las cámaras hijos de los jugadores es que no pueden moverse independientemente de los jugadores.
// Por ejemplo, si el jugador rota, la cámara también rotará. Este podría ser el comportamiento deseado para una cámara en primera persona, pero no para una cámara en tercera persona.
// Recomiendo que las cámaras en tercera persona no sean hijos de los jugadores y que se muevan independientemente de ellos.
// Las cámaras en primera persona funcionan bien como hijos y no necesitan este script.
// Paradójicamente, este script debería de ser usado para la tercera persona y lo usaron para la primera persona.

public class FollowPlayer1 : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 4, 0);

    void Start(){
        transform.position = new Vector3(0.66f,4.11f,-13.36f);
    }
  
    void LateUpdate(){
        transform.position = player.transform.position + offset;
    }
}
