using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{
    // The colors that the game object will cycle through
    public Color[] colors;

    // The renderer that will be used to set the color of the game object
    private Renderer renderer;

    // The current and target colors
    private Color currentColor;
    private Color targetColor;

    // The transition speed
    public float transitionSpeed = 1f;

    void Start()
    {
        // Get the renderer component
        renderer = GetComponent<Renderer>();

        // Set the current and target colors to a random color from the colors array
        currentColor = colors[Random.Range(0, colors.Length)];
        targetColor = colors[Random.Range(0, colors.Length)];

        // Set the initial color and emission of the game object
        renderer.material.color = currentColor;
        renderer.material.SetColor("_EmissionColor", currentColor);

        // Invoke the ChangeColor function repeatedly
        InvokeRepeating("ChangeColor", 0f, 1f);
    }

    void ChangeColor()
    {
        // Set the target color to a random color from the colors array
        targetColor = colors[Random.Range(0, colors.Length)];
    }

    void Update()
    {
        // Smoothly transition the color and emission of the game object towards the target color
        currentColor = Color.Lerp(currentColor, targetColor, transitionSpeed * Time.deltaTime);
        renderer.material.color = currentColor;
        renderer.material.SetColor("_EmissionColor", currentColor);
    }
}
