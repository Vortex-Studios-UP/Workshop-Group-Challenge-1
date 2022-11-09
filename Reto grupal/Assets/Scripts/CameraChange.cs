using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject Camara1;
    public GameObject Camara2;
    public int CamMode;

    void Update()
    {if(Input.GetButtonDown("Camara"))
        {
            if (CamMode == 1)
                CamMode = 0;
            else
                CamMode += 1;
            StartCoroutine(CamChange());
        }
        
    }
    IEnumerator CamChange()

    {
        yield return new WaitForSeconds(0.01f);
        if (CamMode == 0)
        {
            Camara1.SetActive(true);
            Camara2.SetActive(false);
        }
        if (CamMode == 1)
        {
            Camara2.SetActive(true);
            Camara1.SetActive(false);
        }
    }
}