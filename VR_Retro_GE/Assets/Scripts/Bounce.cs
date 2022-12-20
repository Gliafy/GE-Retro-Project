using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float bounciness = 1.0f; // the bounciness of the rigidbody
    public float bouncinessDecay = 0.1f; // the rate at which bounciness decays over time

    private Rigidbody rb; // the Rigidbody component attached to the game object

    private bool startBouncing = false; // flag to indicate when to start bouncing

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

        // start the coroutine to wait for 3 seconds before starting the bouncing effect
        StartCoroutine(WaitForThreeSeconds());
    }

    private IEnumerator WaitForThreeSeconds()
    {
        yield return new WaitForSeconds(3f);
        startBouncing = true;
    }

    private void Update()
    {
        if (!startBouncing)
        {
            return;
        }

        // only decrease bounciness if the rigidbody is not moving
        if (rb.velocity.magnitude < 0.01f)
        {
            bounciness = Mathf.Max(0, bounciness - bouncinessDecay * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!startBouncing)
        {
            return;
        }

        // add an upward force to the rigidbody to make it bounce
        rb.AddForce(Vector3.up * bounciness, ForceMode.Impulse);
    }
}
