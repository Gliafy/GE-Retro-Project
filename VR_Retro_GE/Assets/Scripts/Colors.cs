using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colors : MonoBehaviour
{
    // Declare a list of colors that you want to use
    public Color[] colors;

    void Start()
    {
        // Choose a random color from the list of colors
        int index = Random.Range(0, colors.Length);
        Color color = colors[index];

        // Set the color of the prefab
        GetComponent<Renderer>().material.color = color;
    }
}
