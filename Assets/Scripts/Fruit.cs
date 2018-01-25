using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour {

    bool corte = false;
	public float startForce = 15f;

	Rigidbody2D rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
		rb.AddForce(transform.up * startForce, ForceMode2D.Impulse);
	}

    void Update ()
    {
        if(corte == true){
            if(gameObject.transform.localScale.x > 0){
            gameObject.transform.localScale -= new Vector3(Time.deltaTime * 2, Time.deltaTime * 2, Time.deltaTime * 2);            
            }else{
                Destroy(gameObject, 1.0f);
            }
        }
    }
	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Blade")
		{
			
            corte = true;
            gameObject.GetComponent<Collider2D>().enabled = false;            
                           
        }
    }
}

