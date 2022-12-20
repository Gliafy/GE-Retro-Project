using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloodlightInterval : MonoBehaviour
{
    public float interval = 1.0f; // interval at which the light should turn on and off
    public float startTime = 0.0f; // time at which the light should start turning on and off
    public Light light; // reference to the Point Light component

    void Update()
    {
        // check if it's time to turn the light on or off
        if (Time.time > startTime)
        {
            // toggle the light on or off
            light.enabled = !light.enabled;

            // increment the start time by the interval
            startTime = Time.time + interval;
        }
    }
}