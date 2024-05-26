using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject inimigo;
    public float spawnRate;
    private float nextSpawn = 0f;

    void Update()
    {
         if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            Instantiate(inimigo, transform.position, inimigo.transform.rotation);
        }
    }
}
