using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SFXVolumeScript : MonoBehaviour
{

    Slider SFXSlider;
    public static float SFXVolume;

    void Start()
    {

        if( SFXVolume == 0 )
        {

            SFXVolume = gameObject.GetComponent<Slider>().value;

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
