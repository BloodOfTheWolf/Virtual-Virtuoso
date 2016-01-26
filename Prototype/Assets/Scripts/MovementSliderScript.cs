using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MovementSliderScript : MonoBehaviour
{
    public static float SpeedValue;

    void Start()
    {
        SpeedValue = gameObject.GetComponent<Slider>().value;
    }

    public void OnValueChanged(float NewValue)
    {
        SpeedValue = NewValue;
        Debug.Log("MovementSliderScript: SpeedValue = " + SpeedValue);
    }
}
