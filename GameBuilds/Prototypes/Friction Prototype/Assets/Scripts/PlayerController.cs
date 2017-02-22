using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Rigidbody2D rb;
	public float speed = 10;
	public Vector3 initialBoost;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = initialBoost;
	}

	void FixedUpdate ()
	{
		if (Input.GetButtonDown ("Player1"))
		{
			rb.AddForce(transform.up * speed);
		}
	}

	void OnTriggerStay2D(Collider2D other)
	{
		if (other.gameObject.tag == "Tiles") 
		{
			rb.velocity = Vector3.MoveTowards (rb.velocity, new Vector3 (0, 0, 0), 1);
		}
	}
}
