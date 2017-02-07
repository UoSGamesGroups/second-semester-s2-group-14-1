using UnityEngine;
using System.Collections;

public class MouseManager : MonoBehaviour
{
    float dragSpeed = 5f;
    Rigidbody2D grabbedObject;

    void Start()
    {

    }

	void Update ()
    {
		if (Input.GetMouseButtonDown(0) && grabbedObject == null)
        {
            Vector3 mouseWorldPos3D = Camera.main.ScreenToWorldPoint(Input.mousePosition); //Converts screen space into world space, Reletive to camera position.
            Vector2 mousePos2D = new Vector2(mouseWorldPos3D.x, mouseWorldPos3D.y);


            // Sets up a raycast from the mouse position to check if anything with a box collider and rigidbody has been hit.
            Vector2 dir = Vector2.zero;
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, dir);
            if(hit != null && hit.collider != null)
            {
                if (hit.collider.GetComponent<Rigidbody2D>() != null)
                {
                    grabbedObject = hit.collider.GetComponent<Rigidbody2D>();
                    grabbedObject.gravityScale = 0;
                }
            }
        }

       if (Input.GetMouseButtonUp(0) && grabbedObject != null)
        {
            grabbedObject.gravityScale = 2;
            grabbedObject = null;
        }
	}

    void FixedUpdate()
    {
        if(grabbedObject != null)
        {
            Vector3 mouseWorldPos3D = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mouseWorldPos3D.x, mouseWorldPos3D.y);

            Vector2 dir = mousePos2D - grabbedObject.position;
            dir *= dragSpeed;

            grabbedObject.velocity = dir;
        }
    }

	void OnButtonClick()
	{
		
	}
}
