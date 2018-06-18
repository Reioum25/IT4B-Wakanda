using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Members
{

	public class GuessingGame : MonoBehaviour 
	{
		private int Min;
		private int Max;
		private int Answer;
		// Use this for initialization
		void Start () 
		{
			Answer = 0;
			Min = 0;
			Max = 300;

			Debug.Log("Welcome");
			Debug.Log("Pick a number between 0 to 300");
			Debug.Log("Highest number is: " + Max);
			Debug.Log("Lowest number is: " + Min);

			GetGuess();
		}
		
		// Update is called once per frame
		void Update ()
		{
			if(Input.GetKeyDown(KeyCode.UpArrow))
			{
				Min = Answer;
				// Debug.Log("Min" + Min);
				GetGuess();
			}
			else if(Input.GetKeyDown(KeyCode.DownArrow))
			{
				Max = Answer;
				// Debug.Log("Max" + Max);
				GetGuess();
			}
			else if(Input.GetKeyDown(KeyCode.Space)){
				Debug.Log("The Answer is " + Answer);
			}
		}

		private void GetGuess()
		{
			Answer = (Min + Max) / 2;
			Debug.Log("Is the number: " + Answer + " ?");
			Debug.Log("Is the guess higher [UpArrow] or lower [DownArrow] than: " + Answer + " ? (Press the spacebar if the number is guessed correctly)");
			return;
			
		}
	}
}