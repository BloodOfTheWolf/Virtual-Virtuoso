using UnityEngine;
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

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "TutorialNote") 
		{
			
			print ("Bar colided colided");
		}
	}
}