﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Rigidbody2D rb;
	public float speed = 10;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate ()
	{
		if (Input.GetButtonDown ("Player1"))
		{
			rb.AddForce (transform.up * speed);
		}
	}
		
}