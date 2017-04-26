using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour 
{
	public bool picked = false;
	//public PlayerController playerController;
	//public float speedBoost;

	void Start()
	{
		//playerController = GetComponent<PlayerController>;
	}

	// Use this for initialization
	void OnTriggerEnter2D (Collider2D other) 
	{
		if (other.gameObject.tag == "Player1" || other.gameObject.tag == "Player2")
		{
			picked = true;
			Debug.Log ("Player Hit");
			//playerController.rb.AddForce (transform.right * speedBoost, ForceMode2D.Impulse);
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
