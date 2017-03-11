using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {
	
	public AudioClip cheer;
	public AudioClip brassBand;
	public AudioClip cannon;

	void Start () 
	{
		audio = GetComponent<AudioSource> ();
		audio.Play (cheer, 1);
	}
	

	void Update ()
	{
		audio.Play (cheer, 1);
	}
}
