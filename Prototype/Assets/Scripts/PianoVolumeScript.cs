﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PianoVolumeScript : MonoBehaviour {

	Slider PianoVolSlider;
	public static float PKVolume;

	// Use this for initialization
	void Start () 
	{
        if( PKVolume == 0 )
        {

            PKVolume = gameObject.GetComponent<Slider>().value;

        }
        else
        {
            gameObject.GetComponent<Slider>().value = PKVolume;
        }
		
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void OnValueChanged(float NewValue)
	{
		PKVolume = NewValue;
		
	}
    public void OnValueChangedInGame( float NewValue )
    {
        GameObject[] Keys;
        Keys = GameObject.FindGameObjectsWithTag( "PianoKey" );
        for( int i = 0; i < Keys.Length; i++ )
        {
            Keys[i].GetComponent<AudioSource>().volume = NewValue;
        }

    }
}
