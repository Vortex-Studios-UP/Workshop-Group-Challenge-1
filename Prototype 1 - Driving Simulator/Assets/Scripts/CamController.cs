using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
