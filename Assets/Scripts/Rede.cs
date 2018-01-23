using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rede : MonoBehaviour
{

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Debug.Log("rede");
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "bom")
        {
            Debug.Log("bom");
            Point(true);
        }
        if (col.tag == "ruim")
        {
            Debug.Log("ruim");
            Point(false);
        }
    }

    void Point(bool value)
    {

    }

}
