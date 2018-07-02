using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour {

	[SerializeField]
	public void Play()
	{
		SceneManager.LoadScene(1);
	}

	[SerializeField]
	public void Exit()
	{
		Application.Quit();
	}

	[SerializeField]
	public void ReturnToTheMenu()
	{
		SceneManager.LoadScene(0);
	}
}
