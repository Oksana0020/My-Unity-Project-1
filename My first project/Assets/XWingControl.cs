using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XWingControl : MonoBehaviour
{
    Vector3 velocity, accelaration;
    float rotationspeed = 180;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame 
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            accelaration = transform.forward;

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0, 1), rotationspeed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(new Vector3(1, 0, 0), rotationspeed * Time.deltaTime);

        }
        velocity += accelaration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;
    }
}
