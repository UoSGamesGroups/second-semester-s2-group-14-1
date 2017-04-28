using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseWheelController : MonoBehaviour {

	public bool isGrounded;
	public float waitTime;

	public GameObject[] objectsToThrow;

	// Use this for initialization
	void Start ()
	{
		isGrounded = true;
		StartCoroutine(throwTimer());
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}


	private IEnumerator throwTimer()
	{
		yield return new WaitForSeconds(waitTime);
		if (isGrounded)
		{
			int index = Random.Range(0, objectsToThrow.Length-1);
			Vector2 thisPos = gameObject.transform.position;
			Instantiate(objectsToThrow[index], new Vector2(thisPos.x + 0.5f, thisPos.y + 0.5f), Quaternion.identity);
		}
		StartCoroutine(throwTimer());
	}

    private void OnCollisionEnter2D(Collision2D col)
    {
    	if (col.gameObject.tag == "Ground")
    	{
    		isGrounded = true;
    	}
    }

    private void OnCollisionExit2D(Collision2D col)
    {
    	if (col.gameObject.tag == "Ground")
    	{
    		isGrounded = false;
    	}
    }
}
