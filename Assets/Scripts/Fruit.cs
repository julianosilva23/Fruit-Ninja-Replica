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
        if(corte == true && gameObject != null){
            if(gameObject.transform.localScale.x >= 0.1){
            gameObject.transform.localScale -= new Vector3(Time.deltaTime * 2, Time.deltaTime * 2, Time.deltaTime * 2);            
            }else{
                Destroy(gameObject);
            }
        }
    }
	
    void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Blade" && gameObject != null)
		{
            gameObject.GetComponent<Collider2D>().enabled = false;
            gameObject.GetComponent<Transform>().GetChild(0).tag = "none";            
            corte = true;            
        }

        if (col.tag == "Rede" && gameObject != null &&  gameObject.GetComponent<Collider2D>().enabled == true)
		{
           gameObject.GetComponent<Collider2D>().enabled = false;  
           //Debug.Log("rede item");
            
        }

        if (col.tag == "Limite" && gameObject != null)
		{			            
            Destroy(gameObject);                     
        }
    }
}

