using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuy : MonoBehaviour
{
    public string name;
    public int power;

    public BadGuy(string newname,int newPower)
    {
        name = newname;
        power = newPower;
    }
}
