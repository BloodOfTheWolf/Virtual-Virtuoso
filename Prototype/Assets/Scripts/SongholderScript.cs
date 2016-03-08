using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class SongholderScript : MonoBehaviour {

	public static bool IsCreated = false;

	public static float BGMVolume;
	public static AudioSource BGSong;
	Slider BGMSlider;

	//public static List<AudioSource> songs = new List<AudioSource>();


	// Use this for initialization
	void Start () 
	{

		//if (ListOfNames == ListofAduiSources[i].name)
		//play me

		BGMSlider = GameObject.Find("BGMSlider").GetComponent<Slider> ();
		if (!IsCreated) 
		{
			IsCreated = true;
			BGSong = GetComponent<AudioSource>();
			BGSong.Play ();
			DontDestroyOnLoad(this.gameObject) ;
			BGMVolume = BGMSlider.value;
            print( "entered !iscreated" );

		}
		//otherwise, if we do, kill this thing
		else 
		{
			Destroy (this.gameObject);
           // BGSong.volume = BGMSliderScript.BGVolumeVal;
            print( "entered else of !iscreated" );

		}

        
	}

}
