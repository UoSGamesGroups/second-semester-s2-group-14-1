using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float initialBoost;

    public float jump;
    public float movement;
    public bool grounded = true;

    public bool shouldStart = false;

	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        //rb.velocity = initialBoost;
        
	}
	
	void Update ()
    {
        if (shouldStart)
        {
            rb.AddForce(transform.right * initialBoost, ForceMode2D.Impulse);
            shouldStart = false;
        }
        //rb.AddForce(transform.right * movement);
        if (Input.GetKeyDown(KeyCode.W) && grounded == true)
        {
            grounded = false;
            Jump();
        }
	}

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }

    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jump);
    }
}
