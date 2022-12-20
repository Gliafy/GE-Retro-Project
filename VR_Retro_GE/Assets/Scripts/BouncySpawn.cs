using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySpawn : MonoBehaviour
{
    // Drag in the prefab that you want to spawn in the Inspector
    public GameObject prefabToSpawn;

    // Set the number of prefabs to spawn in the Inspector
    public int numberToSpawn = 10;

    // Drag in the game object that will be used as the spawn location in the Inspector
    public GameObject spawnLocationObject;

    // Drag in the game object that will be used as the button to trigger the spawning in the Inspector
    public GameObject spawnButton;

    void Start()
    {
        // Add a collider to the button game object so that it can be clicked
        spawnButton.AddComponent<BoxCollider>();

        Vector3 spawnLocation = spawnLocationObject.transform.position;

        for (int i = 0; i < numberToSpawn; i++)
        {
            Instantiate(prefabToSpawn, spawnLocation, Quaternion.identity);
        }
    }

    void Update()
    {
        // Check if the button game object is being clicked
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == spawnButton)
                {
                    // Get the spawn location from the spawn location game object
                    Vector3 spawnLocation = spawnLocationObject.transform.position;

                    // Spawn the specified number of prefabs
                    for (int i = 0; i < numberToSpawn; i++)
                    {
                        Instantiate(prefabToSpawn, spawnLocation, Quaternion.identity);
                    }
                }
            }
        }
    }
}