using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{

    public GameObject vehicle;

    // Update is called once per frame
    void Update()
    {
        Instantiate(vehicle, transform.position, vehicle.transform.rotation);
    }
}
