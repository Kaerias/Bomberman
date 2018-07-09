using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNbr : MonoBehaviour
{
	private int nbr;
	private int nbrBomb;
	private int nbrBombUse;

	private void Start()
	{
		nbrBombUse = 0;
		nbrBomb = 1;
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

	public int NbrBomb
	{
		get
		{
			return nbrBomb;
		}

		set
		{
			nbrBomb = value;
		}
	}

	public int NbrBombUse
    {
        get
        {
            return nbrBombUse;
        }

        set
        {
            nbrBombUse = value;
        }
    }
}
