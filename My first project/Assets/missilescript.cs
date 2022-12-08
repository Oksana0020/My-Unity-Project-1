using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missilescript : MonoBehaviour
{

    float MissileSpeed = 30f;
    private float power;
    private float radius;
    private object explosion;

    public object Explosion { get; private set; }

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
        print("Oops I hit something");
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }

    private void Destroy(object gameObject)
    {
        throw new NotImplementedException();
    }


    public void Explode()
    {
        Vector3 explosionPos = transform.position;
        float explosionRadius = 1;
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);

        GameObject explosion = Instantiate(Explosion, transform.position, Quaternion.identity);
        explosion.transform.parent = this.transform;

        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();




            if (rb != null)
                rb.AddExplosionForce(power, explosionPos, radius, 3.0f);
        }
        Destroy(this.gameObject);
    }

    private GameObject Instantiate(object explosion, Vector3 position, Quaternion identity)
    {
        throw new NotImplementedException();
    }

// Applies an explosion force to all nearby rigidbodies
public class ExampleClass : MonoBehaviour
{
    public float radius = 5.0F;
    public float power = 10.0F;

    void Start()
    {
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
                rb.AddExplosionForce(power, explosionPos, radius, 5.0F);
        }
    }
}
}
