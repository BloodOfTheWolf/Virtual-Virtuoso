using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PianoVolumeScript : MonoBehaviour {

	public static float PianoVol;
	public static Slider PianoVolSlider;
	public static float PKVolume;

	// Use this for initialization
	void Start () 
	{
		PianoVolSlider = GameObject.Find ("PianoSlider").GetComponent<Slider>();
		PKVolume = PianoVolSlider.value;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void OnValueChanged(float NewValue)
	{
		PKVolume = NewValue;
		
	}
}
