using UnityEngine;
using System.Collections;

public class SongholderScript : MonoBehaviour {


	public AudioSource BGSong;
	private static bool IsCreated = false;
	// Use this for initialization
	void Start () 
	{
		BGSong = GetComponent<AudioSource>();
		if (!IsCreated) 
		{
			IsCreated = true;
			BGSong.Play ();
			DontDestroyOnLoad(this.gameObject) ;
		}
		//otherwise, if we do, kill this thing
		else 
		{
			Destroy (this.gameObject);
		}	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
