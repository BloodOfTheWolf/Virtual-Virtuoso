using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MovementSliderScript : MonoBehaviour
{
    public float SpeedValue;
    GameObject MovementController;

    void Awake()
    {
        MovementController = GameObject.Find("MovementController");

        SpeedValue = gameObject.GetComponent<Slider>().value;
        MovementController.GetComponent<MovementController>().MovementSpeed = SpeedValue;

        Debug.Log("MovementSliderScript: SpeedValue = " + SpeedValue);
    }

    public void OnValueChanged(float NewValue)
    {
        SpeedValue = NewValue;
        Debug.Log("MovementSliderScript: SpeedValue = " + SpeedValue);
    }
}
