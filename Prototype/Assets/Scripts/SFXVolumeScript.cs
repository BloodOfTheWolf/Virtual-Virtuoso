using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SFXVolumeScript : MonoBehaviour
{

    public static float SFXVol;
    public static Slider SFXSlider;
    public static float SFXVolume;

    // Use this for initialization
    void Start()
    {
        SFXSlider = GameObject.Find( "Slider" ).GetComponent<Slider>();
        SFXVolume = SFXSlider.value;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnValueChanged( float NewValue )
    {
        SFXVolume = NewValue;

    }
}
