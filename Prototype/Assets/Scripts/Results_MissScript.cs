using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Results_MissScript : MonoBehaviour {
	
	
	private SheetNoteScript MissedNotes;
	private int Missed;
	// Use this for initialization
	void Start () 
	{
		Missed = SheetNoteScript.Miss;
		Text MissText = GetComponent<Text> ();
		MissText.text = Missed.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}