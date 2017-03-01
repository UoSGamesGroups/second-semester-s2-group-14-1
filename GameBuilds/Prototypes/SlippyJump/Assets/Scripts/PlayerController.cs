using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
	public Vector2 initialBoost;

    public float jump;
    public float movement;
    public bool grounded = true;

	//public bool gameEnded = false;

    //public bool shouldStart = false;

	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
		rb.velocity = initialBoost;
        
	}
	
	void Update ()
    {
        //if (shouldStart)
        //{
        //rb.AddForce(transform.right * initialBoost);
        //  shouldStart = false;
        //}
        //rb.AddForce(transform.right * movement);
        if (gameObject.tag == "Player1")
        {
            if (Input.GetKeyDown(KeyCode.W) && grounded == true)
            {
                grounded = false;
                Jump();
            }

            if (rb.velocity.x <= +1)
            {
                //gameEnded = true;
                PlayerTwoWin();
            }
        }

        if (gameObject.tag == "Player2")
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) && grounded == true)
            {
                grounded = false;
                Jump();
            }

            if (rb.velocity.x <= +1)
            {
                //gameEnded = true;
                PlayerOneWin();
            }
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

	public void PlayerOneWin()
	{
		SceneManager.LoadScene (1);
	}

    public void PlayerTwoWin()
    {
        SceneManager.LoadScene(2);
    }


}
