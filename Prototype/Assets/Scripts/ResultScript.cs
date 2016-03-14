using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResultScript : MonoBehaviour
{
    private NoteStreakControllerScript Results;
	private int Score = NoteStreakControllerScript.Score;
    private float ScoreInitializer;
    Text ScoreText;
    float scoreTimer;
    float scoreTimeLimit;

    public GameObject Controller;
    bool Complete = false;
	
	void Start()
	{
        Controller = GameObject.Find( "ResultsScreenProgressControl" );
        ScoreInitializer = 0;

        ScoreText = GetComponent<Text>();
        scoreTimer = 0;
        scoreTimeLimit = 2.0f;
	}

    void Update()
    {

        //while( ScoreInitializer != Score )
        //{

        if( (Input.GetMouseButtonDown( 0 )) && (ScoreInitializer != Score) )
        {
            ScoreInitializer = NoteStreakControllerScript.Score;
        }
        
        //check the ProgressionScript for what step the results screen is on
        if( Controller.GetComponent<Results_ProgressionScript>().ResultsStep == 1 )
        {
            var ScoreF = (float)Score;

            scoreTimer += Time.deltaTime;
            float prcComplete = scoreTimer / scoreTimeLimit;
            // don't modify the start and end values here 
            // prcComplete will grow linearly but if you change the start/end points
            // it will add a cumulating error

            if( ScoreInitializer != ScoreF )
            {
                ScoreInitializer = Mathf.Lerp( 0, ScoreF, prcComplete );

            }

            if( (ScoreInitializer == Score) && (Complete == false)||(Complete == false) && (ScoreInitializer == 0) )
            {
                Controller.GetComponent<Results_ProgressionScript>().PlayCrash();
                Complete = true;
            }
        }

        ScoreText.text = ScoreInitializer.ToString( "N0" );
        

        //}

        //if (ScoreInitializer != Score)
        //{
        //    if( (Score - ScoreInitializer) > 1000 )
        //    {
        //        ScoreInitializer += 75;
        //    }
        //    else if( (Score - ScoreInitializer) <= 1000 )
        //    {
        //        ScoreInitializer += 50;
        //    }
        //    else if( (Score - ScoreInitializer) <= 500 )
        //    {
        //        ScoreInitializer += 25;
        //    }
        //    else if( (Score - ScoreInitializer) <= 100 )
        //    {
        //        ScoreInitializer += 10;
        //    }
        //    else if( (Score - ScoreInitializer) < 100 )
        //    {
        //        ScoreInitializer += 1;
        //    }
        //}
    }
}
