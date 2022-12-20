using UnityEngine;

public class Rainbow : MonoBehaviour
{
    Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        float t = Mathf.PingPong(Time.time * 0.5f, 1);

        Color[] rainbowColors = {
            Color.red,
            //Color.orange,
            Color.yellow,
            Color.green,
            Color.blue,
            new Color(75f / 255f, 0f, 130f / 255f),  // indigo
            new Color(238f / 255f, 130f / 255f, 238f / 255f)  // violet
        };

        int index = (int)(t * (rainbowColors.Length - 1));
        Color startColor = rainbowColors[index];
        Color endColor = rainbowColors[index + 1];
        Color interpolatedColor = Color.Lerp(startColor, endColor, t * (rainbowColors.Length - 1) - index);
        renderer.material.color = interpolatedColor;
    }
}