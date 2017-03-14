using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OnClick : MonoBehaviour
{

	public GameObject loadingImage;

	public void LoadScene(int level)
	{
		//loadingImage.SetActive(true);
		SceneManager.LoadScene(level);
	}

	public void ApplicationQuit()
	{
		Application.Quit ();
	}
}
