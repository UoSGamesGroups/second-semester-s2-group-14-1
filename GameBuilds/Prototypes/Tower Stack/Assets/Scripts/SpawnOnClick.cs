using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnClick : MonoBehaviour 
{
	public Transform triangleSelector;
	public Transform plankSelector;
	public Transform boxSelector;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown (0) && gameObject.tag =="TriangeSelector") 
		{
			var mousePos = Input.mousePosition;
			mousePos.z = 2f;

			var objectPos = Camera.main.ScreenToWorldPoint(mousePos);
			Instantiate(gameObject, objectPos, Quaternion.identity);
		}

		if (Input.GetMouseButtonDown (0) && gameObject.tag =="PlankSelector") 
		{
			var mousePos = Input.mousePosition;
			mousePos.z = 2f;

			var objectPos = Camera.main.ScreenToWorldPoint(mousePos);
			Instantiate(gameObject, objectPos, Quaternion.identity);
		}

		if (Input.GetMouseButtonDown (0) && gameObject.tag =="BoxSelector") 
		{
			var mousePos = Input.mousePosition;
			mousePos.z = 2f;

			var objectPos = Camera.main.ScreenToWorldPoint(mousePos);
			Instantiate(gameObject, objectPos, Quaternion.identity);
		}
	}
}
