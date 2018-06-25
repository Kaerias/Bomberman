using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoard : MonoBehaviour {

	GameObject[] GroundObject;
	[SerializeField]
	public GameObject[] players;
	[SerializeField]
	public KeyCode[] keyBomb;

	// Use this for initialization
	void Start () {
		int i = 0;

		GroundObject = GameObject.FindGameObjectsWithTag("Ground");
		foreach (GameObject ground in GroundObject)
		{
			ground.GetComponent<DetectObject>().Nbr = i;
			i++;
		}
		for (int u = 0; u < players.Length; u++)
		{
			players[u].GetComponent<PlayerNbr>().Nbr = u;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(keyBomb[0]))
		{
			GetComponent<PutBomb>().BombGround(players[0], GroundObject);
		}
		else if (Input.GetKeyDown(keyBomb[1]))
		{
			GetComponent<PutBomb>().BombGround(players[1], GroundObject);
		}
	}
}
