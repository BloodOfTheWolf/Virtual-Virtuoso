using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class TutorialNoteScript : MonoBehaviour
{
	
	 public GameObject NotetoLit;
	 //private float NoteVol;

	AudioSource sheetaudio;
	
	void Start()
	{
		sheetaudio = GetComponent<AudioSource>();
//		NoteVol = PianoVolumeScript.PKVolume;
//		sheetaudio.volume = NoteVol; 
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Bar") 
		{
			NotetoLit.SetActive(true);
			sheetaudio.Play();
			print("tutorial collided");
		}
	}

	void OnTriggerExit(Collider other)
	{
			NotetoLit.SetActive(false);	
	}

}
