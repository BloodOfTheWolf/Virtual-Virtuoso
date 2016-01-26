using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SFXVolumeScript : MonoBehaviour
{

    public static float SFXVol;
    public static Slider SFXSlider;
    public static float SFXVolume;

    void Start()
    {
        SFXSlider = GameObject.Find( "SFXSlider" ).GetComponent<Slider>();
        SFXVolume = SFXSlider.value;
    }

    public void OnValueChanged( float NewValue )
    {
        SFXVolume = NewValue;

    }
}
