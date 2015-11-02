using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class PianoKeyScript : MonoBehaviour 
{
		//private int index;
		//private GameObject[] PianoKeys;
	//public AudioClip note;
	// las notas y el teclado deben tener un index

	AudioSource audio;
	GameObject[] barnotes;
	GameObject LitNote;

	//BarNotesScript BarNoteNumber;
	public int Keynumber;

		// Use this for initialization
		void Awake () 
		{
			// only to be done once. not in update
		    audio = GetComponent<AudioSource>();
			barnotes = GameObject.FindGameObjectsWithTag ("BarNote");
			LitNote = gameObject.transform.GetChild (0).gameObject;

		

		}
		
		// Update is called once per frame
		void Update ()
		{

			
		}
		
	void OnMouseDown()
	{
		audio.Play();
		switch (Keynumber) 
		{
		case 0:
			barnotes[0].SetActive(true);
			LitNote.SetActive(true);
			break;

		case 1:
			barnotes[0].SetActive(true);
			LitNote.SetActive(true);
			break;

		case 2:
			barnotes[2].SetActive(true);
			LitNote.SetActive(true);
			break;

		case 3:
			barnotes[2].SetActive(true);
			LitNote.SetActive(true);
			break;

		case 4:
			barnotes[1].SetActive(true);
			LitNote.SetActive(true);
			break;

		case 5:
			barnotes[5].SetActive(true);
			LitNote.SetActive(true);
			break;

		case 6:
			barnotes[5].SetActive(true);
			LitNote.SetActive(true);
			break;

		case 7:
			barnotes[4].SetActive(true);
			LitNote.SetActive(true);
			break;

		case 8:
			barnotes[4].SetActive(true);
			LitNote.SetActive(true);
			break;

		case 9:
			barnotes[6].SetActive(true);
			LitNote.SetActive(true);
			break;

		case 10:
			barnotes[6].SetActive(true);
			LitNote.SetActive(true);
			break;
		case 11:
			barnotes[3].SetActive(true);
			LitNote.SetActive(true);
			break;
		}
		//barnotes
		
	}
	void OnMouseUp()
	{
		switch (Keynumber) 
		{
		case 0:
			barnotes[0].SetActive(false);
			LitNote.SetActive(false);
			break;
			
		case 1:
			barnotes[0].SetActive(false);
			LitNote.SetActive(false);
			break;
			
		case 2:
			barnotes[2].SetActive(false);
			LitNote.SetActive(false);
			break;
			
		case 3:
			barnotes[2].SetActive(false);
			LitNote.SetActive(false);
			break;
			
		case 4:
			barnotes[1].SetActive(false);
			LitNote.SetActive(false);
			break;
			
		case 5:
			barnotes[5].SetActive(false);
			LitNote.SetActive(false);
			break;
			
		case 6:
			barnotes[5].SetActive(false);
			LitNote.SetActive(false);
			break;
			
		case 7:
			barnotes[4].SetActive(false);
			LitNote.SetActive(false);
			break;
			
		case 8:
			barnotes[4].SetActive(false);
			LitNote.SetActive(false);
			break;
			
		case 9:
			barnotes[6].SetActive(false);
			LitNote.SetActive(false);
			break;
			
		case 10:
			barnotes[6].SetActive(false);
			LitNote.SetActive(false);
			break;
		case 11:
			barnotes[3].SetActive(false);
			LitNote.SetActive(false);
			break;
		}
		
	}
		void OnTriggerEnter(Collider other)
		{
			//if(other.tag == "Checkpoints")
			//{
			//	index = System.Array.IndexOf(Checkpoints,other.gameObject);
			//}
			//else if(other.tag == "killer")
			//{
			//	HealthPts = 0;
			//}
			//if(other.tag == "wincube")
			//{
			//	Application.Quit();
			//	UnityEditor.EditorApplication.isPlaying = false;
			//}
			
		}
	}