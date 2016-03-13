using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Results_GoodScript : MonoBehaviour
{
    private NoteStreakControllerScript GoodNotes;
    private int Good;

    float GoodInitializer = 0;
    float GoodTimer = 0.0f;
    float GoodTimeLimit = 2.0f;
    Text GoodText;

    public GameObject Controller;

    bool Complete = false;

    void Start()
    {
        Good = NoteStreakControllerScript.Hit;
        GoodText = GetComponent<Text>();
        Controller = GameObject.Find( "ResultsScreenProgressControl" );
    }

    void Update()
    {

        //check the ProgressionScript for what step the results screen is on
        if( Controller.GetComponent<Results_ProgressionScript>().ResultsStep == 2 )
        {
            if( (Input.GetMouseButtonDown( 0 )) && (GoodInitializer != Good) )
            {
                GoodInitializer = NoteStreakControllerScript.Hit;
            }

            var GoodF = (float)Good;

            GoodTimer += Time.deltaTime;
            float prcComplete = GoodTimer / GoodTimeLimit;
            // don't modify the start and end values here 
            // prcComplete will grow linearly but if you change the start/end points
            // it will add a cumulating error

            if( GoodInitializer != GoodF )
            {
                GoodInitializer = Mathf.Lerp( 0, GoodF, prcComplete );
            }
        }

        if( (GoodInitializer == Good) && (Complete == false) )
        {
            Controller.GetComponent<Results_ProgressionScript>().PlayCrash();
            Complete = true;
        }

        GoodText.text = GoodInitializer.ToString( "N0" );
    }
}
