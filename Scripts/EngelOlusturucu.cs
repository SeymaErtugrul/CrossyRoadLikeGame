using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngelOlusturucu : MonoBehaviour
{
    public float spawnDelay = 0.1f;
    public GameObject araba;
    float nexttimeSpawn = 0f;
   
   
    void Update()
    {
        if (nexttimeSpawn <= Time.time)
        {
            EngelOlustur();
            nexttimeSpawn = Time.time+ spawnDelay;
        }
        
    }

    void EngelOlustur()
    {
        Instantiate(araba);
    }
}
