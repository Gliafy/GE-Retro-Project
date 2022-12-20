/*

using System.Drawing;
using UnityEngine;
using Color = System.Drawing.Color;

public class WaterScript : UnityEngine.MonoBehaviour
{
    public Color[] colors;

    private Color[] GetColors()
    {
        return colors;
    }

    void Update(Color[] colors)
    {
        // Calculate an offset based on the current time
        float offset = Time.time / 2;

        // Set the material's color to the next color in the array
        int v = (int)offset % colors.Length;
        int colorIndex = v;
        GetComponent<Renderer>().material.color = (Color)colors[colorIndex];
    }
}*/