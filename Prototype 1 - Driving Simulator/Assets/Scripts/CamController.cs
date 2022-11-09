using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 2022-11-08 - RETROALIMENTACIÓN DE CHRISTIAN
// Buen funcionamiento de script.
// Se recomienda usar el mismo script para manejar las dos cámaras. 
// El comporamiento de este script es reusable con el de CamControllerP2.cs. 
// No es necesario crear dos scripts cuando la única diferencia es el input.

public class CamController : MonoBehaviour{   

    public GameObject mainCam;
    public GameObject cam2;

    private void Start()
    {
        mainCam.SetActive(true);
        cam2.SetActive(false);

    }
    void Update(){
        if(Input.GetButtonDown("Camera")){
            if(mainCam.activeInHierarchy == true){
                mainCam.SetActive(false);
                cam2.SetActive(true);
            }
            else{
                mainCam.SetActive(true);
                cam2.SetActive(false);
            }
            Debug.Log("T");
        }
    }
}
