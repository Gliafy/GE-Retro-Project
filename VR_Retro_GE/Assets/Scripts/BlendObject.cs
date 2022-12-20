using UnityEngine;

public class BlendObject : MonoBehaviour
{
    public GameObject prefabToInstantiate;
    public string tagToReplace;

    void OnTriggerEnter(Collider other)
    {
        if (Input.GetMouseButton(0))
        {
            if (other.tag == tagToReplace)
            {
                // Create an instance of the prefab at the same position and orientation as the original object
                GameObject newObject = Instantiate(prefabToInstantiate, transform.position, transform.rotation);

                // Destroy the original object
                Destroy(other.gameObject);
            }
        }
    }
}