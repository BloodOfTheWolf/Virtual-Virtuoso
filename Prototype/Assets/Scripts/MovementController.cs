using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MovementController : MonoBehaviour
{
    static MovementController instance;
    public Slider SpeedSlider;
    public float MovementSpeed = 2;

    void Awake()
    {
        if (instance)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        Debug.Log("MovementController: Resetting MovementSpeed...");

        // Reset the movement speed
        ChangeSpeed();
    }
	
	public void ChangeSpeed()
    {
        // Get the value...
        MovementSpeed = SpeedSlider.GetComponent<Slider>().value;

        Debug.Log("MovementController: MovementSpeed = " + MovementSpeed);
	}
}
