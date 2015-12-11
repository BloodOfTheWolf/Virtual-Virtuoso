using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class TutorialNoteScript : MonoBehaviour {
	
	 public GameObject NotetoLit;
	 //private float NoteVol;

	AudioSource sheetaudio;
	// Use this for initialization
	void Start () 
	{
		sheetaudio = GetComponent<AudioSource>();
//		NoteVol = PianoVolumeScript.PKVolume;
//		sheetaudio.volume = NoteVol; 
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Bar") 
		{
			NotetoLit.SetActive(true);
			sheetaudio.Play();
			print ("tutorial colided");
		}
	}

	void OnTriggerExit(Collider other)
	{
			NotetoLit.SetActive(false);	
	}

}
