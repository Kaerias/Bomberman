using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGame : MonoBehaviour {

	GameObject[] Objects;
	GameObject[] players;
	[SerializeField]
	public GameObject Game;
	[SerializeField]
	public Text winText;
	[SerializeField]
	public GameObject Button;
	string winnerName;
	int i;

	// Use this for initialization
	void Start () {
		i = 0;
	}
	
	// Update is called once per frame
	void Update () {
		players = GameObject.FindGameObjectsWithTag("Player");
		if (players != null && Button != null)
		{
			i = 0;
			foreach (GameObject player in players)
			{
				winnerName = player.name;
				i++;
			}
			if (i == 1)
			{
				winText.text = "player win = " + winnerName;
				Game.SetActive(false);
				Button.SetActive(true);
				DestroyAllObject();
			}
		}
	}

	private void DestroyAllObject()
	{
		Objects = GameObject.FindGameObjectsWithTag("Fire");
		foreach (GameObject obj in Objects)
		{
			Destroy(obj);
		}
		Objects = GameObject.FindGameObjectsWithTag("Bomb Up");
		foreach (GameObject obj in Objects)
		{
			Destroy(obj);
		}
	}
}
