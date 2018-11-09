using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdS : MonoBehaviour {
	public float upForce;					
	private bool isDead = false;			

	private Animator anim;					
	private Rigidbody2D rd2d;				

	void Start()
	{
		
		anim = GetComponent<Animator> ();
		//Get and store a reference to the Rigidbody2D attached to this GameObject.
		rd2d = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		
		if (isDead == false) 
		{
			
			if (Input.GetMouseButtonDown(0)) 
			{
				
				anim.SetTrigger("Flap");

				rd2d.velocity = Vector2.zero;
				//	new Vector2(rb2d.velocity.x, 0);
				rd2d.AddForce(new Vector2(0, upForce));
			}
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		
		rd2d.velocity = Vector2.zero;

		isDead = true;

		anim.SetTrigger ("Die");

	//	GamecontrolScript.instance.BirdDied ();
	}
}
