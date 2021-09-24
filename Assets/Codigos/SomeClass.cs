using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeClass : MonoBehaviour
{
    
    void Start()
    {
        List<BadGuy> badguys = new List<BadGuy>();

        badguys.Add(new BadGuy("Fuego", 50));
        badguys.Add(new BadGuy("Electricidad", 100));
        badguys.Add(new BadGuy("Viento", 5));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
