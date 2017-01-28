using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour {

	public Rigidbody2D rb;
	public float speed = 10;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate ()
	{
		if (Input.GetButtonDown ("Player2"))
		{
			rb.AddForce (transform.up * speed);
		}
	}
		
}
