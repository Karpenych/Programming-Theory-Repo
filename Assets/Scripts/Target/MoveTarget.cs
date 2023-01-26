using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveTarget : MonoBehaviour
{
    private float speed = 10;
    private float xRange = 25;
    private Vector3 direction = Vector3.right;


    void Update()
    {
        if (transform.position.x > xRange)
        {
            direction = Vector3.left;
        }
        if (transform.position.x < -xRange)
        {
            direction = Vector3.right;
        }

        transform.Translate(speed * Time.deltaTime * direction);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        GetComponent<AudioSource>().Play();
    }
}
