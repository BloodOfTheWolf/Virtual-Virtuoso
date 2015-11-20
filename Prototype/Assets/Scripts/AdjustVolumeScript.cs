using UnityEngine;
using System.Collections;

public class AdjustVolumeScript : MonoBehaviour {


	public float volume = 0.5f;
	AudioSource BackGroundMusic;
	// Use this for initialization
	void Start () 
	{
			BackGroundMusic = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AdjustVolume(float newVolume)
	{
		BackGroundMusic.volume = newVolume;
	}
}
