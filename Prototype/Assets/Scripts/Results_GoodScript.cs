using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Results_GoodScript : MonoBehaviour
{
    private NoteStreakControllerScript GoodNotes;
	private int Good;
	
	void Start()
	{
        Good = NoteStreakControllerScript.Hit;
		Text GoodText = GetComponent<Text> ();
        GoodText.text = Good.ToString( "N0" );
	}
}
