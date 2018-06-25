using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour {

	private GameObject MoreBomb;
	private GameObject TmpMoreBomb;

	// Use this for initialization
	void Start () {
		MoreBomb = Resources.Load("more_prefab") as GameObject;
	}

	// Update is called once per frame
	void Update()
	{

	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Fire")
		{
			if ((int)Random.Range(0, 100) >= 90)
			{
				TmpMoreBomb = Instantiate(MoreBomb, transform.position, Quaternion.Euler(180, 180, 0)) as GameObject;
				TmpMoreBomb.transform.position += new Vector3(0, 0.5f, -0.5f);
			}
			Destroy(gameObject);
		}
		if (other.gameObject.tag == "Player")
		{
			Destroy(other.gameObject);
		}
	}
}
