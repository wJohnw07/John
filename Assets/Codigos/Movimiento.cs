using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float force = 150;
    Rigidbody rb;
    void Start()
    {
        rb =  GetComponent < Rigidbody  >();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 vector = new Vector3(h, 0.5f, v);
        rb.AddForce(vector * force * Time.deltaTime);
    }
}
