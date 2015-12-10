using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class PianoKeyScript : MonoBehaviour 
{

	AudioSource audio;
	public GameObject barnotes;
	GameObject LitNote;
	//BarNotesScript BarNoteNumber;
	public int Keynumber;
		// Use this for initialization
		void Awake () 
		{
			// only to be done once. not in update
		    audio = GetComponent<AudioSource>();
			LitNote = gameObject.transform.GetChild (0).gameObject;
			//notesHitBox = GameObject.FindWithTag(ajorHitbox)
		

		}
		
		// Update is called once per frame
		void Update ()
		{

			
		}
		
	void OnMouseDown()
	{

			audio.Play ();
			barnotes.SetActive (true);
			LitNote.SetActive (true);
	}
	void OnMouseUp()
	{

		barnotes.SetActive(false);
		LitNote.SetActive(false);
	}
		
	void OnTriggerEnter(Collider other)
	{
	}

}