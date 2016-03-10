using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Results_MissScript : MonoBehaviour
{
    private NoteStreakControllerScript MissedNotes;
	private int Missed;
	
	void Start() 
	{
        Missed = NoteStreakControllerScript.Miss;
		Text MissText = GetComponent<Text>();
        MissText.text = Missed.ToString( "N0" );
	}
}