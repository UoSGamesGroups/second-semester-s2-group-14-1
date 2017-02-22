using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _GameManager : MonoBehaviour
{
	#region PlayerController
	public PlayerController playerController;
	public PlayerController2 playerController2;
	#endregion

	void Start ()
	{
		
	}

	void Update () 
	{

		/*if(playerController.rb.velocity == 0)
		{
			SceneManager.LoadScene(2);
		}

		if(playerController2.rb.velocity == 0)
		{
			SceneManager.LoadScene(3);
		}*/
	}
}
