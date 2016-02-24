using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HitNotesResults : MonoBehaviour
{
	private NoteStreakControllerScript Result;
	private int HitNotes;
	
	void Start() 
	{
        HitNotes = NoteStreakControllerScript.Hit;
		Text HitNotesText = GetComponent<Text>();
		HitNotesText.text = HitNotes.ToString();
	}
}