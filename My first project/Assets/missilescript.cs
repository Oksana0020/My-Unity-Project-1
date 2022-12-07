using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missilescript : MonoBehaviour
{

    float MissileSpeed = 30f;
    private float power;
    private float radius;

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
        Destroy(collision.gameObject);
        Destroy(gameObject);
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
}
