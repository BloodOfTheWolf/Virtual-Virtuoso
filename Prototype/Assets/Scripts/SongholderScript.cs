using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class SongholderScript : MonoBehaviour {

	public static bool IsCreated = false;

	public static float BGMVolume;
	public static AudioSource BGSong;
	Slider BGMSlider;
    public static int CurrentSong;
    public static bool FindToggle;
    public static bool ItsPlaying;
    

	//public static List<AudioSource> songs = new List<AudioSource>();


	// Use this for initialization
	void Start () 
	{
        
		//if (ListOfNames == ListofAduiSources[i].name)
		//play me
        print(" its playing value"  + ItsPlaying );
		BGMSlider = GameObject.Find("BGMSlider").GetComponent<Slider> ();
		if (!IsCreated) 
		{
			IsCreated = true;
			BGSong = GetComponent<AudioSource>();
            if(CurrentSong == 0)
            {
                print( "entered start is created current song = 0" );
                ChangeBackgroundSong( 1 );
            }
            else
            {
                print( "entered start is created else" );
                ChangeBackgroundSong( CurrentSong );

            }
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
            //ToggleSongIcon( CurrentSong );
		}
        
        
	}

    public void ChangeBackgroundSong(int i)
    {
        switch(i)
        {
        case 1:
        if( BGSong.clip.name != "02 Piano" || IsCreated == true)
        {
            print( "entered changebgs case 1" );
            BGSong.clip = Resources.Load<AudioClip>( "Songs/02 Piano" );
            if( BGSong.isPlaying == false )
            {
                print( "entered is playing" );
                BGSong.Play();
                ItsPlaying = true;
            }
        }
        CurrentSong = 1;
        break;
        case 2:
        if( BGSong.clip.name != "mus_etude_32khz"  )
        {
            print( "entered changebgs case 2" );
            BGSong.clip = Resources.Load<AudioClip>( "Songs/mus_etude_32khz" );
            if( BGSong.isPlaying == false )
            {
                print( "entered is playing" );
                BGSong.Play();
            }
        }
        CurrentSong = 2;
        break;
        case 3:
        if( BGSong.clip.name != "mus_sonata_32khz"  )
        {
            print( "entered changebgs case 3" );
            BGSong.clip = Resources.Load<AudioClip>( "Songs/mus_sonata_32khz" );
            if( BGSong.isPlaying == false )
            {
                print( "entered is playing" );
                BGSong.Play();
            }
        }
        CurrentSong = 3;
        break;
        case 4:
        if( BGSong.clip.name != "mus_jesu_32khz"  )
        {
            print( "entered changebgs case 4" );
            BGSong.clip = Resources.Load<AudioClip>( "Songs/mus_jesu_32khz" );
            if( BGSong.isPlaying == false )
            {
                print( "entered is playing" );
                BGSong.Play();
            }
        }

        CurrentSong = 4;
        break;
        case 5:
        if( BGSong.clip.name != "mus_rondo_32khz"  )
        {
            print( "entered changebgs case 5" );
            BGSong.clip = Resources.Load<AudioClip>( "Songs/mus_rondo_32khz" );
            if( BGSong.isPlaying == false )
            {
                print( "entered is playing" );
                BGSong.Play();
            }
        }
        CurrentSong = 5;
        break;

        }
    }

    public void ToggleSongIcon(int i)
    {
        switch(i)
        {
        case 1:
        FindToggle = GameObject.Find( "FirstSongToggle" ).GetComponent<Toggle>().isOn = true;
        break;
        case 2:
        FindToggle = GameObject.Find( "EtudeToggle" ).GetComponent<Toggle>().isOn = true;
        break;
        case 3:
        FindToggle = GameObject.Find( "SonataToggle" ).GetComponent<Toggle>().isOn = true;
        break;
        case 4:
        FindToggle = GameObject.Find( "JesuToggle" ).GetComponent<Toggle>().isOn = true;
        break;
        case 5:
        FindToggle = GameObject.Find( "RondoToggle" ).GetComponent<Toggle>().isOn = true;
        break;

        }
    }

    public static void CheckAvailable()
    {
        if(BGMusicSetController.SetOneBought == false)
        {
            FindToggle = GameObject.Find( "EtudeToggle" ).GetComponent<Toggle>().interactable = false;
        }
        else
        {
            FindToggle = GameObject.Find( "EtudeToggle" ).GetComponent<Toggle>().interactable = true;
        }
        if( BGMusicSetController.SetTwoBought == false )
        {
            FindToggle = GameObject.Find( "SonataToggle" ).GetComponent<Toggle>().interactable = false;
        }
        else
        {
            FindToggle = GameObject.Find( "SonataToggle" ).GetComponent<Toggle>().interactable = true;
        }
        if( BGMusicSetController.SetThreeBought == false )
        {
            FindToggle = GameObject.Find( "JesuToggle" ).GetComponent<Toggle>().interactable = false;
        }
        else
        {
            FindToggle = GameObject.Find( "JesuToggle" ).GetComponent<Toggle>().interactable = true;
        }
        if( BGMusicSetController.SetFourBought == false )
        {
            FindToggle = GameObject.Find( "RondoToggle" ).GetComponent<Toggle>().interactable = false;
        }
        else
        {
            FindToggle = GameObject.Find( "RondoToggle" ).GetComponent<Toggle>().interactable = true;
        }
    }

}
