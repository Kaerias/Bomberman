using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bomb : MonoBehaviour {

	GameObject[] TmpFire;
	[SerializeField]
	public GameObject Fire;
	private float cooldown;
	private GameObject Player;

	// Use this for initialization
	void Start () {
		cooldown = Time.time + 3f;
		TmpFire = new GameObject[5];
	}

	// Update is called once per frame
	void Update () {
		if (Player != null)
		{
			if (Time.time >= cooldown)
			{
				for (int i = 0; i < 5; i++)
				{
					TmpFire[i] = Instantiate(Fire, transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
				}
				TmpFire[0].transform.position += new Vector3(0, 0f, -1.5f);
				TmpFire[1].transform.position += new Vector3(0, 0f, 0.5f);
				TmpFire[2].transform.position += new Vector3(-1f, 0f, -0.5f);
				TmpFire[3].transform.position += new Vector3(1f, 0f, -0.5f);
				TmpFire[4].transform.position += new Vector3(0f, 0f, -0.5f);
				for (int i = 0; i < 5; i++)
				{
					Destroy(TmpFire[i], 2f);
				}
				if (Player.GetComponent<PlayerNbr>().NbrBombUse > 0)
				{
					Player.GetComponent<PlayerNbr>().NbrBombUse -= 1;
				}
				Destroy(gameObject);
			}
		}
	}

	public GameObject Player1
	{
		set
		{
			Player = value;
		}
	}

}
