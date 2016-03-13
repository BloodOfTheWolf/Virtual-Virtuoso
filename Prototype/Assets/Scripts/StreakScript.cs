using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StreakScript : MonoBehaviour
{
    private NoteStreakControllerScript Result;
    private int Streak;
    float StreakInitializer = 0;
    float StreakTimer = 0.0f;
    float StreakTimeLimit = 2.0f;
    Text StreakText;

    public GameObject Controller;

    bool Complete = false;

    void Start()
    {
        Streak = NoteStreakControllerScript.HighestStreak;
        StreakText = GetComponent<Text>();
        Controller = GameObject.Find( "ResultsScreenProgressControl" );
    }

	void Update()
	{

        //check the ProgressionScript for what step the results screen is on
        if( Controller.GetComponent<Results_ProgressionScript>().ResultsStep == 1 )
        {
            if( (Input.GetMouseButtonDown( 0 )) && (StreakInitializer != Streak) )
            {
                StreakInitializer = NoteStreakControllerScript.HighestStreak;
            }

            var StreakF = (float)Streak;

            StreakTimer += Time.deltaTime;
            float prcComplete = StreakTimer / StreakTimeLimit;
            // don't modify the start and end values here 
            // prcComplete will grow linearly but if you change the start/end points
            // it will add a cumulating error

            if( StreakInitializer != StreakF )
            {
                StreakInitializer = Mathf.Lerp( 0, StreakF, prcComplete );
            }
        }

        if( (StreakInitializer == Streak) && (Complete == false) )
        {
            Controller.GetComponent<Results_ProgressionScript>().PlayCrash();
            Complete = true;
        }

        StreakText.text = StreakInitializer.ToString( "N0" );
	}
}
