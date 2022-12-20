using UnityEngine;

public class BlenderSpin : MonoBehaviour
{
    public float rotationAmount = 45f; // specify the rotation amount in degrees
    // Update is called once per frame
    void Update()
    {
        // Check if the left mouse button is held down
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(0f, rotationAmount * Time.deltaTime,0f ); // rotate the object around the z-axis
        }
    }

}
