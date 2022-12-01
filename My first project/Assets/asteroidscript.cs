using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidscript : MonoBehaviour
{

    Vector3 velocity,axisOfRotation;

    float speed, speedRoation;
    float MAXSPEED = 5, MINSPEED = 10;
    private float maxDistance = 300;
    private float maxAsteroidSize = 100;

    // Start is called before the first frame update
    void Start()
    {

        transform.position = UnityEngine.Random.Range(0, maxDistance)*  getRandomDirection();
        transform.localScale = UnityEngine.Random.Range(1, maxAsteroidSize) * Vector3.one;

        speed = UnityEngine.Random.Range(MINSPEED, MAXSPEED);
        velocity = speed * getRandomDirection();

        axisOfRotation = getRandomDirection();
        speedRoation = UnityEngine.Random.Range(20, 90);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += velocity * Time.deltaTime;
        transform.Rotate(axisOfRotation, speedRoation * Time.deltaTime);
    }



    Vector3 getRandomDirection()
    {

        Vector3 randomVector = new Vector3(UnityEngine.Random.Range(-1.0f, 1.0f), UnityEngine.Random.Range(-1.0f, 1.0f), UnityEngine.Random.Range(-1.0f, 1.0f));

        return randomVector.normalized;

    }
}
