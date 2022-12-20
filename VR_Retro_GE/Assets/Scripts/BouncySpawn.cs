using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySpawn : MonoBehaviour
{
    public GameObject prefabToSpawn; // the prefab that you want to spawn
    public int numberToSpawn; // the number of prefabs to spawn
    public GameObject spawnLocation; // the GameObject that determines the location where the prefabs should be spawned

    void Start()
    {
        // use a loop to spawn the specified number of prefabs
        for (int i = 0; i < numberToSpawn; i++)
        {
            // instantiate the prefab at the position of the spawnLocation GameObject
            Instantiate(prefabToSpawn, spawnLocation.transform.position, Quaternion.identity);
        }
    }
}
