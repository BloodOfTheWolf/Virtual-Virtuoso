using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HeldStarUpdateScript : MonoBehaviour 
{
    public static int Stars;
    public string Song;
    public PlayerScoreInfoScript StarsNumber;

    void Start()
    {
        this.gameObject.transform.GetChild( 0 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( false );
        this.gameObject.transform.GetChild( 1 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( false );
        this.gameObject.transform.GetChild( 2 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( false );
        CheckStars();
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

    public void CheckStars( )
    {
        switch(Song)
        {
        case "Twinkle":
            if(PlayerScoreInfoScript.TwinkleStars == 1)
            {
                this.gameObject.transform.GetChild( 0 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( true );
            }
            else if( PlayerScoreInfoScript.TwinkleStars == 2 )
            {
                this.gameObject.transform.GetChild( 0 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( true );
                this.gameObject.transform.GetChild( 1 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( true );
            }
            else if( PlayerScoreInfoScript.TwinkleStars == 3 )
            {
                this.gameObject.transform.GetChild( 0 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( true );
                this.gameObject.transform.GetChild( 1 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( true );
                this.gameObject.transform.GetChild( 2 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( true );
            }
            break;
        case "HotCross":
            if( PlayerScoreInfoScript.CrossStars == 1 )
            {
                this.gameObject.transform.GetChild( 0 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( true );
            }
            else if( PlayerScoreInfoScript.CrossStars == 2 )
            {
                this.gameObject.transform.GetChild( 0 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( true );
                this.gameObject.transform.GetChild( 1 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( true );
            }
            else if( PlayerScoreInfoScript.CrossStars == 3 )
            {
                this.gameObject.transform.GetChild( 0 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( true );
                this.gameObject.transform.GetChild( 1 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( true );
                this.gameObject.transform.GetChild( 2 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( true );
            }
            break;
        case "MountainKing":
            if (PlayerScoreInfoScript.TwinkleStars >= 2 && PlayerScoreInfoScript.CrossStars >= 2)
            {

                gameObject.transform.parent.GetChild(3).gameObject.SetActive(false);
                if (PlayerScoreInfoScript.MountainKingStars == 1)
                {
                    this.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.SetActive(true);
                }
                else if (PlayerScoreInfoScript.MountainKingStars == 2)
                {
                    this.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.SetActive(true);
                    this.gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.SetActive(true);
                }
                else if (PlayerScoreInfoScript.MountainKingStars == 3)
                {
                    this.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.SetActive(true);
                    this.gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.SetActive(true);
                    this.gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.SetActive(true);
                }
            }
            break;
        case "FurElise":
            if( PlayerScoreInfoScript.TwinkleStars >= 2  && PlayerScoreInfoScript.CrossStars >= 2 )
            {

                gameObject.transform.parent.GetChild( 3 ).gameObject.SetActive( false );
                if( PlayerScoreInfoScript.EliseStars == 1 )
                {
                    this.gameObject.transform.GetChild( 0 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( true );
                }
                else if( PlayerScoreInfoScript.EliseStars == 2 )
                {
                    this.gameObject.transform.GetChild( 0 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( true );
                    this.gameObject.transform.GetChild( 1 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( true );
                }
                else if( PlayerScoreInfoScript.EliseStars == 3 )
                {
                    this.gameObject.transform.GetChild( 0 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( true );
                    this.gameObject.transform.GetChild( 1 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( true );
                    this.gameObject.transform.GetChild( 2 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( true );
                }
            }
            break;
        case "Entertainer":
            if( PlayerScoreInfoScript.TwinkleStars >= 2 && PlayerScoreInfoScript.CrossStars >= 2 )
            {
                gameObject.transform.parent.GetChild( 3 ).gameObject.SetActive( false );
                if( PlayerScoreInfoScript.EntertainerStars == 1 )
                {
                    this.gameObject.transform.GetChild( 0 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( true );
                }
                else if( PlayerScoreInfoScript.EntertainerStars == 2 )
                {
                    this.gameObject.transform.GetChild( 0 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( true );
                    this.gameObject.transform.GetChild( 1 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( true );
                }
                else if( PlayerScoreInfoScript.EntertainerStars == 3 )
                {
                    this.gameObject.transform.GetChild( 0 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( true );
                    this.gameObject.transform.GetChild( 1 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( true );
                    this.gameObject.transform.GetChild( 2 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( true );
                }
            }

            break;
        case "Canon":
            if (PlayerScoreInfoScript.MountainKingStars >= 2 && PlayerScoreInfoScript.EliseStars >= 2 && PlayerScoreInfoScript.EntertainerStars >= 2)
            {
                gameObject.transform.parent.GetChild( 3 ).gameObject.SetActive( false );
                if( PlayerScoreInfoScript.CanonStars == 1 )
                {
                    this.gameObject.transform.GetChild( 0 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( true );
                }
                else if( PlayerScoreInfoScript.CanonStars == 2 )
                {
                    this.gameObject.transform.GetChild( 0 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( true );
                    this.gameObject.transform.GetChild( 1 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( true );
                }
                else if( PlayerScoreInfoScript.CanonStars == 3 )
                {
                    this.gameObject.transform.GetChild( 0 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( true );
                    this.gameObject.transform.GetChild( 1 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( true );
                    this.gameObject.transform.GetChild( 2 ).gameObject.transform.GetChild( 0 ).gameObject.SetActive( true );
                }
            }
            break;
        }
    }
}
