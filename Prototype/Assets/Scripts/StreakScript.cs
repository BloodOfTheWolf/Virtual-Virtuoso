using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StreakScript : MonoBehaviour
{
	private SheetNoteScript Result;
	private int Streak;

	void Start() 
	{
		Streak = SheetNoteScript.HighestStreak;
		Text StreakText = GetComponent<Text> ();
		StreakText.text = Streak.ToString();
	}
}
