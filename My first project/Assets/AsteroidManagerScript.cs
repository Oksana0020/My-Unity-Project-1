using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidManagerScript : MonoBehaviour
{


    public GameObject AsteroidCloneTemplate;
    private int NumberOfAsteroids = 200;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < NumberOfAsteroids; i++)
            Instantiate(AsteroidCloneTemplate);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
