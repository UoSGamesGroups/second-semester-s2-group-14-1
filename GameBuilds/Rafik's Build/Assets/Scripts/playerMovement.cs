using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float MovespeedP1;
    public float MovespeedP2;
    // Use this for initialization
    void Start()
    {
        MovespeedP1 = 0.1f;
        MovespeedP2 = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up") && gameObject.tag == "P1")
        {
            transform.Translate(0, MovespeedP1, 0);
        }



        if (Input.GetKeyDown("w") && gameObject.tag == "P2")
        {
            transform.Translate(0, MovespeedP2, 0);
        }

    }
}
