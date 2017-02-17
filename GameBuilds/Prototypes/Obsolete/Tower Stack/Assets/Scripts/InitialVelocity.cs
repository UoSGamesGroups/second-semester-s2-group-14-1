using UnityEngine;
using System.Collections;

public class InitialVelocity : MonoBehaviour
{
    public Vector3 initVel;
    Rigidbody2D rb;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = initVel;
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
