using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Results_MissScript : MonoBehaviour
{
    private NoteStreakControllerScript MissedNotes;
	private int Missed;

    float MissInitializer = 0;
    float MissTimer = 0.0f;
    float MissTimeLimit = 2.0f;
    Text MissText;

    public GameObject Controller;

    bool Complete = false;

    void Start()
    {
        Missed = NoteStreakControllerScript.Miss;
        MissText = GetComponent<Text>();
        Controller = GameObject.Find( "ResultsScreenProgressControl" );
    }

    void Update()
    {

        //check the ProgressionScript for what step the results screen is on
        if( Controller.GetComponent<Results_ProgressionScript>().ResultsStep == 4 )
        {
            if( (Input.GetMouseButtonDown( 0 )) && (MissInitializer != Missed) )
            {
                MissInitializer = NoteStreakControllerScript.Miss;
            }

            var MissF = (float)Missed;

            MissTimer += Time.deltaTime;
            float prcComplete = MissTimer / MissTimeLimit;
            // don't modify the start and end values here 
            // prcComplete will grow linearly but if you change the start/end points
            // it will add a cumulating error

            if( MissInitializer != MissF )
            {
                MissInitializer = Mathf.Lerp( 0, MissF, prcComplete );
                print( "Missinitializer!= MissF = " + MissInitializer );
            }
        if( (MissInitializer == Missed) && (Complete == false) || (MissInitializer == 0) && (Complete == false))
        {
            Controller.GetComponent<Results_ProgressionScript>().PlayCrash();
            Complete = true;
            print( "outside if = " + MissInitializer );
        }
        }


        MissText.text = MissInitializer.ToString( "N0" );
    }
}
