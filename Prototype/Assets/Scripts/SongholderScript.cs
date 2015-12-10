using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SongholderScript : MonoBehaviour {

	private static bool IsCreated = false;

	public static float BGMVolume;
	public static AudioSource BGSong;
	public static Slider BGMSlider;
	// Use this for initialization
	void Start () 
	{
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
