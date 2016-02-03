using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MovementSliderScript : MonoBehaviour
{
    public static float SpeedValue;
    Slider SpeedController;

    void Awake()
    {

        if(SpeedValue == 0)
        {
           
            SpeedValue = gameObject.GetComponent<Slider>().value;
   
        }
        else
        {
            gameObject.GetComponent<Slider>().value = SpeedValue;
        }

        Debug.Log("MovementSliderScript: SpeedValue = " + SpeedValue);
    }

    public void OnValueChanged(float NewValue)
    {
        SpeedValue = NewValue;
        Debug.Log("MovementSliderScript: SpeedValue = " + SpeedValue);
    }
}
