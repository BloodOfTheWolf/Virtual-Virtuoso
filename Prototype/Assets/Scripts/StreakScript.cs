using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StreakScript : MonoBehaviour {
	
	
	private SheetNoteScript Result;
	private int Streak;
	// Use this for initialization
	void Start () 
	{
		Streak = SheetNoteScript.HighestStreak;
		Text StreakText = GetComponent<Text> ();
		StreakText.text = Streak.ToString();

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
