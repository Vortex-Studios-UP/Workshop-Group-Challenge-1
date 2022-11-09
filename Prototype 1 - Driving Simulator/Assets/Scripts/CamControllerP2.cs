using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 2022-11-08 - RETROALIMENTACIÓN DE CHRISTIAN
// Buen funcionamiento de script.
// Este script es innecesario ya que el comportamiento de este script es el mismo que el de "CamController.cs".

public class CamControllerP2 : MonoBehaviour{   

    public GameObject mainCam;
    public GameObject cam2;

    private void Start()
    {
        mainCam.SetActive(true);
        cam2.SetActive(false);

    }
    void Update(){
        if(Input.GetButtonDown("Cam2")){
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
