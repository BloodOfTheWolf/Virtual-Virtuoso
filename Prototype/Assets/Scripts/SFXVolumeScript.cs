using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SFXVolumeScript : MonoBehaviour
{

    Slider SFXSlider;
    public static float SFXVolume;
    static bool Started = false;

    void Start()
    {

        if( SFXVolume == 0 && Started == false )
        {

            SFXVolume = gameObject.GetComponent<Slider>().value;
            Started = true;

        }
        else
        {
            gameObject.GetComponent<Slider>().value = SFXVolume;
        }

        
    }

    public void OnValueChanged( float NewValue )
    {
        SFXVolume = NewValue;
        SFXControllerScript.SFXVol = NewValue;

    }
}
