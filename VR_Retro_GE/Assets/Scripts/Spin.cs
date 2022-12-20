using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float rotationAmount = 45f; // specify the rotation amount in degrees

    void Update()
    {
        transform.Rotate(0f, 0f, rotationAmount * Time.deltaTime); // rotate the object around the z-axis
    }
}
