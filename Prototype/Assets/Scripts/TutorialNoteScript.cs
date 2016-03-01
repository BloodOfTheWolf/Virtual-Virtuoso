using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class TutorialNoteScript : MonoBehaviour
{
	
	 public GameObject NotetoLit;
	 //private float NoteVol;

	AudioSource sheetaudio;
    bool played;
	
	void Start()
	{
		sheetaudio = GetComponent<AudioSource>();
        played = false;
//		NoteVol = PianoVolumeScript.PKVolume;
//		sheetaudio.volume = NoteVol; 
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Bar" && played == false) 
		{
			NotetoLit.SetActive(true);
			sheetaudio.Play();
            played = true;
			//print("tutorial collided");
		}
	}

	void OnTriggerExit(Collider other)
	{
			NotetoLit.SetActive(false);	
	}

}
