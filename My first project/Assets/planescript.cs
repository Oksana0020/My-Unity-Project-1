using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planescript : MonoBehaviour
{

    Vector3  axisOfRotation;

    float  speedRoation;



    // Start is called before the first frame update
    void Start()
    {

        axisOfRotation = Vector3.up;
        speedRoation = 5f;
        float scale = transform.localScale.x;

        Transform glow = transform.Find("EarthGlow");
        float glowScale = glow.localScale.z - 1;

        glow.transform.localScale =(1+  (glowScale / scale)) * Vector3.one;
    }


    void Update()
    {
        transform.Rotate(axisOfRotation, speedRoation * Time.deltaTime);

    }
}
