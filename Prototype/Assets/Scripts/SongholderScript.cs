﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class SongholderScript : MonoBehaviour {

	public static bool IsCreated = false;

	public static float BGMVolume;
	public static AudioSource BGSong;
	public static Slider BGMSlider;

	public static List<AudioSource> songs = new List<AudioSource>();


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

			//BGMVolume = GameObject.Find("BGMSlider").GetComponent<Slider> ().value;
		}
		//otherwise, if we do, kill this thing
		else 
		{
			Destroy (this.gameObject);
			BGMSlider.value = BGMVolume;
		}

        
	}

	public void OnValueChanged(float NewValue)
	{
		BGMVolume = NewValue;
		BGSong.volume = NewValue;
	}

	// Update is called once per frame
	void Update () 
	{
//		BGMVolume = GameObject.Find("BGMSlider").GetComponent<Slider> ().value;
//		BGMSlider.v = BGMVolume;
	}
}
