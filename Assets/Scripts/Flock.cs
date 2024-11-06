using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flock : MonoBehaviour
{
    float speed;

    void Start()
    {
        speed = Random.Range (FlockManager.FM.minSpeed, FlockManager.FM.maxSpeed);
    }

    void Update()
    {
        this.transform.Translate (0, 0, speed * Time.deltaTime);
    }
}
