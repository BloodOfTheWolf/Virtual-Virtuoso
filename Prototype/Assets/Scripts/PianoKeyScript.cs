using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class PianoKeyScript : MonoBehaviour 
{
		//private int index;
		//private GameObject[] PianoKeys;
	//public AudioClip note;
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

		

		}
		
		// Update is called once per frame
		void Update ()
		{

			
		}
		
	void OnMouseDown()
	{
		audio.Play();
		barnotes.SetActive(true);
		LitNote.SetActive(true);
		//barnotes
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