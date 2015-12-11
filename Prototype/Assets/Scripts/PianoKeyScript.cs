using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class PianoKeyScript : MonoBehaviour 
{

	AudioSource audio;
	public GameObject barnotes;
	GameObject LitNote;
	private float NoteVol;
	private GameObject Tutorial;
	private bool Colored;

		// Use this for initialization
		void Awake () 
		{
			Colored = false;
			// only to be done once. not in update
		    audio = GetComponent<AudioSource>();
			NoteVol = PianoVolumeScript.PKVolume;
			audio.volume = NoteVol;

			Tutorial = gameObject.transform.GetChild (1).gameObject;
			if (Colored == false) 
			{
			Tutorial.SetActive(false);

			}
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