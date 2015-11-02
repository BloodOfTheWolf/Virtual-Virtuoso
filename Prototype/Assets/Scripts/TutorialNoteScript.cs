using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class TutorialNoteScript : MonoBehaviour {

	public int NoteNumber;
	GameObject[] NotetoLit;

	AudioSource sheetaudio;
	// Use this for initialization
	void Start () 
	{
		sheetaudio = GetComponent<AudioSource>();
		NotetoLit = GameObject.FindGameObjectsWithTag("LitKey");
		print ("note to lit : " + NotetoLit.Length);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Bar") 
		{
			switch(NoteNumber)
			{
				case 0:
				NotetoLit[4].SetActive(true);
				sheetaudio.Play();
			break;
			case 2:
				NotetoLit[4].SetActive(true);
				sheetaudio.Play();
		
			break;
			case 4:
				NotetoLit[1].SetActive(true);
				sheetaudio.Play();
		
			break;
			case 5:
				NotetoLit[5].SetActive(true);
				sheetaudio.Play();
			
			break;
			case 7:
				NotetoLit[2].SetActive(true);
				sheetaudio.Play();
		
			break;
			case 9:
				NotetoLit[6].SetActive(true);
				sheetaudio.Play();
		
			break;
			case 11:
				NotetoLit[6].SetActive(true);
				sheetaudio.Play();
			
			break;
			}
			print ("tutorial colided");
		}
	}

	void OnTriggerExit(Collider other)
	{

		for (int i = 0; i < NotetoLit.Length; i++) 
		{
			NotetoLit[i].SetActive(false);
		}
	}

}
