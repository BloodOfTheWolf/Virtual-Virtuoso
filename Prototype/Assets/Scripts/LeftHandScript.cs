using UnityEngine;
using System.Collections;

public class LeftHandScript : MonoBehaviour {

    AudioSource sheetaudio;

    void Start()
    {
        sheetaudio = GetComponent<AudioSource>();
        sheetaudio.volume = 1.0f;
        //		NoteVol = PianoVolumeScript.PKVolume;
        //		sheetaudio.volume = NoteVol; 
    }

    void OnTriggerEnter( Collider other )
    {
        if( other.tag == "Bar" )
        {
            sheetaudio.Play();
            print( "Left Hand collided" );
        }
    }
}
