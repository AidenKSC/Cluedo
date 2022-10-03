using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dice2CheckerZone : MonoBehaviour
{
	Vector3 diceVelocity;

	// Update is called once per frame
	void FixedUpdate()
	{
		diceVelocity = dice2Script.dice2Velocity;
	}

	void OnTriggerStay(Collider col)
	{
		if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f)
		{
			switch (col.gameObject.name)
			{
				case "D2Side1":
					DiceNumberTextScript.dice2Number = 6;
					break;
				case "D2Side2":
					DiceNumberTextScript.dice2Number = 5;
					break;
				case "D2Side3":
					DiceNumberTextScript.dice2Number = 4;
					break;
				case "D2Side4":
					DiceNumberTextScript.dice2Number = 3;
					break;
				case "D2Side5":
					DiceNumberTextScript.dice2Number = 2;
					break;
				case "D2Side6":
					DiceNumberTextScript.dice2Number = 1;
					break;
			}
		}
	}
}
