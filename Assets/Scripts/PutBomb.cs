using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutBomb : MonoBehaviour
{

	private GameObject InitBomb;
	private GameObject Bomb;

	// Use this for initialization
	void Start()
	{
		InitBomb = Resources.Load("bomb_prefab") as GameObject;
	}

	// Update is called once per frame
	void Update()
	{
	}

	[HideInInspector]
	public void BombGround(GameObject player, GameObject[] GroundObject)
	{
		if (player != null && GroundObject != null)
		{
			if (player.GetComponent<PlayerNbr>().NbrBomb > player.GetComponent<PlayerNbr>().NbrBombUse)
			{
				player.GetComponent<PlayerNbr>().NbrBombUse += 1;
				foreach (GameObject ground in GroundObject)
				{
					if (ground.GetComponent<DetectObject>().Player && (player.GetComponent<PlayerNbr>().Nbr == ground.GetComponent<DetectObject>().PlayerNbr))
					{
						Bomb = Instantiate(InitBomb, ground.transform.position, transform.rotation) as GameObject;
						Bomb.transform.position += new Vector3(0, 1.2f, 0);
						Bomb.GetComponent<Bomb>().Player1 = player;
						break;
					}
				}
			}
		}	
	}
}
