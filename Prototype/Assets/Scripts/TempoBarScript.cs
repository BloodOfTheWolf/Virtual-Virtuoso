using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TempoBarScript : MonoBehaviour 
{
	//SheetNoteScript sheet;
	// Use this for initialization
	// if  song notes and barnotes are colliding, show right or wrong image
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	public void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Bar") 
		{
			print("bar colided");
			Application.Quit();
			//UnityEditor.EditorApplication.isPlaying = false;
		}
		if (other.tag == "TutorialControl") {
			//DestroyObject(other);
		}

	}
}
