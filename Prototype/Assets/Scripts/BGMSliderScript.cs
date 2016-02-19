using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BGMSliderScript : MonoBehaviour {

    public static float BGVolumeVal;
    Slider BGVolumeController;

	// Use this for initialization
	void Start () 
    {
        if( BGVolumeVal == 0 )
        {

            BGVolumeVal = gameObject.GetComponent<Slider>().value;


        }
        else
        {
             gameObject.GetComponent<Slider>().value = BGVolumeVal ;
            
        }


	
	}

    public void OnValueChanged( float NewValue )
    {
        BGVolumeVal = NewValue;
        SongholderScript.BGSong.volume = NewValue;
  
    }
}
