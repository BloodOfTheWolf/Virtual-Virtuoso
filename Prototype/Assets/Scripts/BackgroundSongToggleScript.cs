using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BackgroundSongToggleScript : MonoBehaviour {

    public static bool Toggle;
    public static int RefNum;
    

	// Use this for initialization
	void Start () 
    {
        SongholderScript.CheckAvailable();
	
	}
	
	public void CheckToggle()
    {
        
       
    }

    public void ChangeBackgroundSong( int i )
    {
        switch( i )
        {
        case 1:
        if( SongholderScript.BGSong.clip.name != "02 Piano" || SongholderScript.IsCreated == true  )
        {
            SongholderScript.BGSong.clip = Resources.Load<AudioClip>( "Songs/02 Piano" );
                print( "entered is playing" );
                SongholderScript.BGSong.Play();
            print( "entered changebgs case 1" );
            //if( SongholderScript.ItsPlaying == false )
            //{
            //}
        SongholderScript.CurrentSong = 1;
        }
        break;
        case 2:
        if( SongholderScript.BGSong.clip.name != "mus_etude_32khz" || SongholderScript.IsCreated == true )
        {
            SongholderScript.BGSong.clip = Resources.Load<AudioClip>( "Songs/mus_etude_32khz" );
            print( "entered changebgs case 2" );
                SongholderScript.BGSong.Play();
            //if( SongholderScript.ItsPlaying == false )
            //{
            //    print( "entered is playing" );
            //}
        SongholderScript.CurrentSong = 2;
        }
        break;
        case 3:
        if( SongholderScript.BGSong.clip.name != "mus_sonata_32khz" || SongholderScript.IsCreated == true )
        {
            SongholderScript.BGSong.clip = Resources.Load<AudioClip>( "Songs/mus_sonata_32khz" );
                print( "entered is playing" );
                SongholderScript.BGSong.Play();
            print( "entered changebgs case 3" );
            //if( SongholderScript.ItsPlaying == false )
            //{
            //}
        SongholderScript.CurrentSong = 3;
        }
        break;
        case 4:
        if( SongholderScript.BGSong.clip.name != "mus_jesu_32khz" || SongholderScript.IsCreated == true )
        {
            SongholderScript.BGSong.clip = Resources.Load<AudioClip>( "Songs/mus_jesu_32khz" );
                print( "entered is playing" );
                SongholderScript.BGSong.Play();
            print( "entered changebgs case 4" );
            //if( SongholderScript.ItsPlaying == false )
            //{
            //}
        SongholderScript.CurrentSong = 4;
        }

        break;
        case 5:
        if( SongholderScript.BGSong.clip.name != "mus_rondo_32khz" || SongholderScript.IsCreated == true )
        {
            SongholderScript.BGSong.clip = Resources.Load<AudioClip>( "Songs/mus_rondo_32khz" );
                print( "entered is playing" );
                SongholderScript.BGSong.Play();
            print( "entered changebgs case 5" );
            //if( SongholderScript.ItsPlaying == false )
            //{
            //}
        SongholderScript.CurrentSong = 5;
        }
        break;

        }
    }
}
