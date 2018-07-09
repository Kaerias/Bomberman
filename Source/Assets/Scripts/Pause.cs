using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

	bool isPause;
	[SerializeField]
	public GameObject Button;
	[SerializeField]
	public GameObject Game;
	[SerializeField]
	public GameObject BackgroundPause;

	// Use this for initialization
	void Start()
	{
		isPause = false;
	}

	// Update is called once per frame
	void Update()
	{
		if (Button != null && Game != null && BackgroundPause != null)
		{
			if (Input.GetKeyDown(KeyCode.P))
			{
				if (isPause == false)
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
                isPause = !isPause;
			}
		}
	}
}
