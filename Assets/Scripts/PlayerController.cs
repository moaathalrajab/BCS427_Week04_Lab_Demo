using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rd;
    private Vector2 vector2;

    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }

    private void OnMove(InputValue input)
    {
        vector2 = input.Get<Vector2>();
    }

    void FixedUpdate()
    {
        rd.AddForce(vector2.x, 0, vector2.y);
    }
}
