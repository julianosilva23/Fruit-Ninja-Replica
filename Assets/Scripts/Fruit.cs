using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour {
	
	public float startForce = 15f;

	Rigidbody2D rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
		rb.AddForce(transform.up * startForce, ForceMode2D.Impulse);
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Blade")
		{
			//Vector3 direction = (col.transform.position - transform.position).normalized;
            
            //while(gameObject.transform.localScale.x > 0)
            //{
                gameObject.transform.localScale -= new Vector3(0.2f, 0.2f, 0.2f);
                Debug.Log(transform.localScale.x);
            //}
            


            gameObject.GetComponent<Collider2D>().enabled = false;
            Destroy(gameObject, 1.0f);
        }
    }

}
