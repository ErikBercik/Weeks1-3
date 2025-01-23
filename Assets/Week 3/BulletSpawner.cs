using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject prefab;
    public Bullet bullet;

    void Start()
    {
        Spawn();
    }

    void Update()
    {
        //if no bullet, make one
        if(bullet == null)
        {
            Spawn();
        }

        //if clicked, fire!
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    void Spawn()
    {
        GameObject spawnedBullet = Instantiate(prefab);
        bullet = spawnedBullet.GetComponent<Bullet>();
    }

    void Fire()
    {
        bullet.hasBeenFired = true;
        // now make the variable null, not the actual object (bullet was referenced earlier in code)
        bullet = null;
    }
}
