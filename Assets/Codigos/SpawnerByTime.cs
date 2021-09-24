using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnerByTime : MonoBehaviour
{

    public float timeToSpawn;
    public float currentSeconds;

    void Start()
    {
        currentSeconds = timeToSpawn;
    }

    
    void Update()
    {
        currentSeconds += Time.deltaTime; 

        if(currentSeconds <= 0)
        {
           
            currentSeconds = timeToSpawn;
        }
    }
}
