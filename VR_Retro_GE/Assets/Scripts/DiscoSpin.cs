using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscoSpin : MonoBehaviour
{
    // Speed of rotation around the x-axis
    public float xSpeed;
    // Speed of rotation around the y-axis
    public float ySpeed;
    // Speed of rotation around the z-axis
    public float zSpeed;
    // Timer for changing colors
    private float colorTimer;

    void Update()
    {
        // Rotate the disco ball around the x-, y-, and z-axes at different speeds
        transform.Rotate(xSpeed * Time.deltaTime, ySpeed * Time.deltaTime, zSpeed * Time.deltaTime);

        // Update the color timer
        colorTimer += Time.deltaTime;
        // If the timer has reached the interval for changing colors
        if (colorTimer >= 0.5f)
        {
            // Reset the timer
            colorTimer = 0;
            // Change the colors of the spot lights
            foreach (Light light in GetComponentsInChildren<Light>())
            {
                light.color = Random.ColorHSV();
            }
        }
    }
}
