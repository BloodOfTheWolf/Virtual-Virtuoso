using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TempoBarScript : MonoBehaviour 
{
	//SheetNoteScript sheet;
	// Use this for initialization
	// if  song notes and barnotes are colliding, show right or wrong image
	public static int Section;
	void Start () 
	{
		Section = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "SectionBar") 
		{
			Section = Section +1;
			print ("Section added");
		}
		 if (other.tag == "Bar") 
		{
			print("bar colided");
			Application.LoadLevel("Results");
			//Application.Quit();
			//UnityEditor.EditorApplication.isPlaying = false;
		}

	}
}
