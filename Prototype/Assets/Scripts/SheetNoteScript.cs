﻿using UnityEngine;
using System.Collections;


[RequireComponent(typeof(AudioSource))]


public class SheetNoteScript : MonoBehaviour {


	AudioSource sheetaudio;
	public GameObject GreenCheck;
	public GameObject RedCheck;
	public static int Score;
	public static int NoteStreak;
	public static int Multiplier = 10;


	// Use this for initialization
	void Start () 
	{
		sheetaudio = GetComponent<AudioSource>();
		Score = 0;
		NoteStreak = 0;

	}
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "BarNote") 
		{
			print ("note hit");

			GreenCheck.SetActive(true);
			this.gameObject.SetActive(false);
			RedCheck.SetActive(false);
			Score = Score + Multiplier;
			NoteStreak++;
			print ("NoteStreak: " + NoteStreak);
			if(NoteStreak == 3 )
			{
				Multiplier = Multiplier * 2;
			}
			//sheetaudio.Play();
			//Debug.Break();
		}


	}

	void OnTriggerExit ( Collider other)
	{
		if (GreenCheck.activeInHierarchy || !(GreenCheck.activeInHierarchy)) 
		{
			RedCheck.SetActive(true);
			GreenCheck.SetActive(false);
			print ("trigger exit called");
			NoteStreak = 0;
			Multiplier = 10;
		}
		//GreenCheck.SetActive (false);
		//RedCheck.SetActive (false);

	}

	void OnGUI()
	{
		GUIStyle style = new GUIStyle();
		style.fontSize = 30;
		GUI.Label (new Rect(220,150,100,100),"Score: "+Score.ToString(),style);
		GUI.Label (new Rect(10,150,100,100),"NoteStreak: "+NoteStreak.ToString(),style);
		
	}

	public void PlayNote()
	{
		sheetaudio.Play ();
	}
}