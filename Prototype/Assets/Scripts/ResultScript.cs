﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResultScript : MonoBehaviour
{
    private NoteStreakControllerScript Results;
	private int Score;
    private int ScoreInitializer;
    Text ScoreText;
	
	void Start() 
	{
        ScoreInitializer = 0;
        Score = NoteStreakControllerScript.Score;

        ScoreText = GetComponent<Text>();
        
	}

    void Update()
    {

        while( ScoreInitializer != Score )
        {
            ScoreInitializer += 2;
            ScoreText.text = ScoreInitializer.ToString( "N0" );

        }

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
