﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Results_GoodScript : MonoBehaviour {
	
	
	private SheetNoteScript GoodNotes;
	private int Good;
	// Use this for initialization
	void Start () 
	{
		Good = SheetNoteScript.Hit;
		Text GoodText = GetComponent<Text> ();
		GoodText.text = Good.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}