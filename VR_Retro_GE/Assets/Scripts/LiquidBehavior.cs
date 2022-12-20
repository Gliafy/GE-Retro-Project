using System.Collections;
using UnityEngine;

public class LiquidBehavior : MonoBehaviour
{
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Apply a downward force to the cube, simulating the effect of gravity
        rb.AddForce(Vector3.down * Time.deltaTime * 9.8f);
    }
}