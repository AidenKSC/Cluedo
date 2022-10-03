using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceNumberTextScript : MonoBehaviour
{
	Text text;
	public static int diceNumber;
	public static int dice2Number;
	public static int totalDiceNumber;

	// Use this for initialization
	void Start()
	{
		text = GetComponent<Text>();
	}

	// Update is called once per frame
	void Update()
	{
		totalDiceNumber = diceNumber + dice2Number;
		text.text = totalDiceNumber.ToString();
	}
}
