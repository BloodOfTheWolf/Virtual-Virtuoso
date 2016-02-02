using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BootScript : MonoBehaviour
{
    /// <summary>
    /// Is the timer running?
    /// </summary>
    bool TimerActive;

    /// <summary>
    /// What's the timer's current value?
    /// </summary>
    public float TimerValue = 2.0f;

    /// <summary>
    /// Which text object are we taking the text component from?
    /// </summary>
    public Text TimerText;

    /// <summary>
    /// What text is displayed to the player?
    /// </summary>
    string TimerTextContent = "Timer: ";

    /// <summary>
    /// What is TimerValue being rounded to?
    /// </summary>
    float TimerValueRounded;


    /// <summary>
    /// Rounding function that lets you specify the number of decimals to round to.
    /// </summary>
    /// <param name="value">The float value to round.</param>
    /// <param name="digits">The number of decimals to round to.</param>
    /// <returns>Float 'value' rounded.</returns>
    public static float Round( float value, int digits )
    {
        float mult = Mathf.Pow( 10.0f, (float)digits );
        return Mathf.Round( value * mult ) / mult;
    }

    /// <summary>
    /// Starts the countdown timer that loads the front end menu upon elapse.
    /// </summary>
    void StartTimer()
    {
        Debug.Log( "BootScript: Starting timer" );
        TimerActive = true;
    }

    /// <summary>
    /// Loads the front end menu.
    /// </summary>
    void LoadFrontEnd()
    {
        Debug.Log( "BootScript: Loading front end" );
        Application.LoadLevel( "MainMenu" );
    }

	void Start()
    {
        StartTimer();
	}

    void Update()
    {
        TimerValueRounded = Round( TimerValue, 2 );
        TimerText.GetComponent<Text>().text = TimerTextContent + TimerValueRounded.ToString();

        if (TimerActive)
        {
            TimerValue -= Time.deltaTime;
        }

        if (TimerValue < 0)
        {
            LoadFrontEnd();
        }
    }
}
