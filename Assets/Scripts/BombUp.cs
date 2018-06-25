using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Bomb Up")
		{
			gameObject.GetComponent<PlayerNbr>().NbrBomb += 1;
			Destroy(other.gameObject);
			print("BOMB UP !");
		}
	}
}
