using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missilescript : MonoBehaviour
{

    float MissileSpeed = 30f;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += MissileSpeed * transform.forward * Time.deltaTime;
    }




    private void OnCollisionEnter(Collision collision)
    {
        print("I hit something");
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }

    void Explode ()
    {
        float explosionRadius = 1;
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach (Collider collider in colliders)
        {
            Destroy(collider.transform);
        }
    }
}
