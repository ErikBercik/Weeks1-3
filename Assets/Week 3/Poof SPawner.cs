using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoofSPawner : MonoBehaviour
{
    public GameObject prefab;
    public poof poof;

    void Start()
    {
        Spawn();
    }

    void Update()
    {
        //make a poof if there isn't one on screen
        if (poof == null)
        {
            Spawn();
        }

    }

    void Spawn()
    {
        GameObject spawnedPoof = Instantiate(prefab);
    }
}
