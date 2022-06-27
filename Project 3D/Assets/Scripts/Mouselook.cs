using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouselook : MonoBehaviour
{
    private float MouseSens;

    void Start()
    {
        
    }

    void Update()
    {
        float xmouse = Input.GetAxis("Mouse X") * MouseSens * Time.deltaTime;
        float ymouse = Input.GetAxis("Mouse Y") * MouseSens * Time.deltaTime;


        Debug.Log(xmouse + " " + ymouse);

    }
}
