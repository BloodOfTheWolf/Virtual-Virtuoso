using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StreakScript : MonoBehaviour
{
    private NoteStreakControllerScript Result;
	private int Streak;

	void Start() 
	{
        Streak = NoteStreakControllerScript.HighestStreak;
		Text StreakText = GetComponent<Text> ();
		StreakText.text = Streak.ToString();
	}
}
