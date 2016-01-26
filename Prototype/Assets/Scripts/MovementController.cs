using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MovementController : MonoBehaviour
{
    static MovementController instance;
    public Slider SpeedSlider;
    public float MovementSpeed;

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
    }
	
	public void ChangeSpeed()
    {
        // Get the value...
        MovementSpeed = SpeedSlider.GetComponent<Slider>().value;
        
        // and negate it
        MovementSpeed *= -1;

        Debug.Log("MovementController: MovementSpeed = " + MovementSpeed);
	}
}
