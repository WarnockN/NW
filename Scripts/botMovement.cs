using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botMovement : MonoBehaviour
{

    float min = 2f;
    float max = 3f;
    public float distance = 20;
    // Use this for initialization
    void Start()
    {

        min = transform.position.x;
        max = transform.position.x + distance;

    }

    // Update is called once per frame
    void Update()
    {


        transform.position = new Vector3(Mathf.PingPong(Time.time * 2, max - min) + min, transform.position.y, transform.position.z);

    }
}