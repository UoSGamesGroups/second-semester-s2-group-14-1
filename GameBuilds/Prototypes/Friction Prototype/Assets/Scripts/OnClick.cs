using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OnClick : MonoBehaviour 
{
	public void sceneChanger(string sceneName)
	{
		SceneManager.LoadScene (sceneName);
	}

	public void exitGame()
	{
		Application.Quit ();
	}
}
