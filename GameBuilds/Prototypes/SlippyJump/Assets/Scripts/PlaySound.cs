using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {
	
	public AudioClip cheer;
	public AudioClip brassBand;
	public AudioClip cannon;

	void Start () 
	{
		//GetComponent<AudioSource>().Play (cheer);
		//GetComponent<AudioSource> ().Play (brassBand);
		GetComponent<AudioSource>().PlayOneShot (cannon, 1);
	}
	

	void Update ()
	{
		
	}
}
