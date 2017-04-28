using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoostSound : MonoBehaviour {

	public AudioClip boost;
	AudioSource audio;

	void Start()
	{
		audio = GetComponent<AudioSource>();
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag == "Player1" || col.gameObject.tag == "Player2")
		{
			audio.PlayOneShot(boost, 0.5f);
		}
	}
}
