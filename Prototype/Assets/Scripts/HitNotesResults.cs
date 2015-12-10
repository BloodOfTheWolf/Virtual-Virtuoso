using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HitNotesResults : MonoBehaviour {
	
	
	private SheetNoteScript Result;
	private int HitNotes;
	// Use this for initialization
	void Start () 
	{
		HitNotes = SheetNoteScript.Hit;
		Text HitNotesText = GetComponent<Text> ();
		HitNotesText.text = HitNotes.ToString();
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}