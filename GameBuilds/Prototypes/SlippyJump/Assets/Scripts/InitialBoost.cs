using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialBoost : MonoBehaviour {

    public Rigidbody2D rb;
    public Vector2 initialBoost;

	void Start ()
    {
        rb = GetComponent < Rigidbody2D>();
        rb.velocity = initialBoost;
	}
	

	void Update ()
    {
		
	}
}
