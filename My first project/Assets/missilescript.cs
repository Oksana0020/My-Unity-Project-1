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

    public float fireInterval = 2f;
    private bool canFire = true;

    public void onRButtonClicked()
    {
        if (canFire)
        {
            FireRockets();
            canFire = false;

            StartCoroutine(ReloadDelay());
        }
    }

    private string ReloadDelay()
    {
        throw new NotImplementedException();
    }

    private void FireRockets()
    {

    }

}
