using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
	//public Vector2 initialBoost;
	public float speed;

	public Text speedText;

    public float jump;
    public float movement;
    public bool grounded = true;

	//private Vector2 speedValue;

	public float speedBoost;

	//public bool gameEnded = false;

    //public bool shouldStart = false;

	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
		rb.AddForce (transform.right * speed, ForceMode2D.Impulse);
		//rb.velocity = initialBoost;
		//speed = rb.velocity;
		//SetSpeedText ();
        
	}
	
	void Update ()
    {
        //if (shouldStart)
        //{
        //rb.AddForce(transform.right * initialBoost);
        //  shouldStart = false;
        //}
        //rb.AddForce(transform.right * movement);
		//SetSpeedText();

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

	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log ("OnTrigger");
		if (other.gameObject.tag == "SpeedBoost") 
		{
			rb.AddForce (transform.right * speedBoost, ForceMode2D.Impulse);
			Debug.Log ("Speed Boost?");
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

	//void SetSpeedText()
	//{
		//speedText.text = "Speed: " + speed.ToString ();
	//}


}
