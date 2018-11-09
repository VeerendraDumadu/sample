using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObjectScript : MonoBehaviour {
	private Rigidbody2D rd2d;


	void Start () 
	{
		rd2d = GetComponent<Rigidbody2D>();


		rd2d.velocity = new Vector2(GamecontrolScript.instance.scrollSpeed, 0);
	}

	void Update()
	{
		
	}
}
