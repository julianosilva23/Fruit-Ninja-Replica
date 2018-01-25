using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rede : MonoBehaviour
{

    void Start()
    {
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
