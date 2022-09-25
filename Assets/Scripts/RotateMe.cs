using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMe : MonoBehaviour
{
    public float speed = 100f;

    void Update()
    {
        transform.RotateAround(transform.position,
            new Vector3(0, 1, 0), Time.deltaTime * speed);
    }
}
