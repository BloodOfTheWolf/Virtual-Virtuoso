using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TempoBarScript : MonoBehaviour 
{
	//SheetNoteScript sheet;
	// Use this for initialization
	// if song notes and barnotes are colliding, show right or wrong image
	public static int Section;
    public GameObject Song;

    GameObject SongProgressionManagerObj;

	void Start() 
	{
		Section = 0;
        Song = GameObject.FindGameObjectWithTag( "SongObject" );
        SongProgressionManagerObj = GameObject.Find( "SongProgressionManager" );
	}

	void OnTriggerEnter(Collider other)
	{
       
		if (other.tag == "SheetNote") 
		{
			print ("hello from tempobar");
            
            Song.GetComponent<MovementScript>().enabled = false;
            
            //GetComponent<MovementScript>().enabled = false;
			Section = Section +1;
		}

		if (other.tag == "Bar") 
		{
			print("bar colided");

            // Update the song's completion state
            SongProgressionManagerObj.GetComponent<SongProgressionManagerScript>().UpdateSongStates( Application.loadedLevelName );

			Application.LoadLevel("Results");
			//Application.Quit();
			//UnityEditor.EditorApplication.isPlaying = false;
		}
	}

}
