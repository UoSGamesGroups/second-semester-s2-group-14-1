using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseChunks : MonoBehaviour 
{
	public Rigidbody2D rb;

	public Vector2 chunkMovement;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		rb.AddForce(chunkMovement, ForceMode2D.Impulse);
	}

	private void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Ground")
		{
			Destroy(this.gameObject);
		}
	}
}
