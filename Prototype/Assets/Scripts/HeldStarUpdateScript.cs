﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HeldStarUpdateScript : MonoBehaviour 
{
    public static int Stars;
    public string Song;
    public PlayerScoreInfoScript StarsNumber;

    void Start()
    {
        
    }
	
	// Update is called once per frame
	void Update () 
    {

        //if (Stars.TwinkleStars > 2)
        //{
        //    TwinkleStarOne.enabled = true;
        //}
        //if (Stars.TwinkleStars > 1)
        //{
        //    TwinkleStarTwo.enabled = true;
        //}
        //if (Stars.TwinkleStars > 0)
        //{
        //    TwinkleStarThree.enabled = true;
        //}

        //if( Stars.CrossStars > 2 )
        //{
        //    CrossStarOne.enabled = true;
        //}
        //if( Stars.CrossStars > 1 )
        //{
        //    CrossStarTwo.enabled = true;
        //}
        //if( Stars.CrossStars > 0 )
        //{
        //    CrossStarThree.enabled = true;
        //}

        //if( Stars.EliseStars > 2 )
        //{
        //    EliseStarOne.enabled = true;
        //}
        //if( Stars.EliseStars > 1 )
        //{
        //    EliseStarTwo.enabled = true;
        //}
        //if( Stars.EliseStars > 0 )
        //{
        //    EliseStarThree.enabled = true;
        //}

        //if( Stars.EntertainerStars > 2 )
        //{
        //    EntertainerStarOne.enabled = true;
        //}
        //if( Stars.EntertainerStars > 1 )
        //{
        //    EntertainerStarTwo.enabled = true;
        //}
        //if( Stars.EntertainerStars > 0 )
        //{
        //    EntertainerStarThree.enabled = true;
        //}

        //if( Stars.CanonStars > 2 )
        //{
        //    CanonStarOne.enabled = true;
        //}
        //if( Stars.CanonStars > 1 )
        //{
        //    CanonStarTwo.enabled = true;
        //}
        //if( Stars.CanonStars > 0 )
        //{
        //    CanonStarThree.enabled = true;
        //}
	}

    public void CheckStars(int i )
    {

        switch(i)
        {
        case 1:

        break;
        case 2:

        break;
        case 3:

        break;

        }

    }
}

