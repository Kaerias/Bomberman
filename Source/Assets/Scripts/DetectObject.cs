using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectObject : MonoBehaviour {

	int	nbr;
	bool player = false;
	int playerNbr;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter(Collision collision)
	{
		player = true;
		playerNbr = collision.gameObject.GetComponent<PlayerNbr>().Nbr;

	}

	private void OnCollisionExit(Collision collision)
	{
		player = false;
	}

	public int Nbr
	{
		get
		{
			return nbr;
		}

		set
		{
			nbr = value;
		}
	}

	public bool Player
	{
		get
		{
			return player;
		}

		set
		{
			player = value;
		}
	}

	public int PlayerNbr
	{
		get
		{
			return playerNbr;
		}

		set
		{
			playerNbr = value;
		}
	}

}
