using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResultScript : MonoBehaviour
{
    private NoteStreakControllerScript Results;
	private int Score;
    private float ScoreInitializer;
    Text ScoreText;
    float scoreTimer;
    float scoreTimeLimit;
	
	void Start()
	{
        ScoreInitializer = 0;
        Score = NoteStreakControllerScript.Score;

        ScoreText = GetComponent<Text>();
        scoreTimer = 0;
        scoreTimeLimit = 2.0f;
	}

    void Update()
    {

        //while( ScoreInitializer != Score )
        //{
            var ScoreF = (float)Score;

            scoreTimer += Time.deltaTime;
            float prcComplete = scoreTimer / scoreTimeLimit;
            // don't modify the start and end values here 
            // prcComplete will grow linearly but if you change the start/end points
            // it will add a cumulating error
            ScoreInitializer = Mathf.Lerp( 0, ScoreF, prcComplete );
            
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
