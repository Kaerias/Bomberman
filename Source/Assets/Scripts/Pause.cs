using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

	bool b;
	[SerializeField]
	public GameObject Button;
	[SerializeField]
	public GameObject Game;
	[SerializeField]
	public GameObject BackgroundPause;

	// Use this for initialization
	void Start()
	{
		b = false;
	}

	// Update is called once per frame
	void Update()
	{
		if (Button != null && Game != null && BackgroundPause != null)
		{
			if (Input.GetKeyDown(KeyCode.P))
			{
				if (b == false)
				{
					Time.timeScale = 0f;
					Game.SetActive(false);
					BackgroundPause.SetActive(true);
					Button.SetActive(true);
				}
				else
				{
					Time.timeScale = 1f;
					Game.SetActive(true);
					BackgroundPause.SetActive(false);
					Button.SetActive(false);
				}
				b = !b;
			}
		}
	}
}
