using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerScoreInfoScript : MonoBehaviour
{
    public float HotCrossScore;
    public float TwinkleTwinkleScore;
    public float CanonScore;
    public float EliseScore;
    public float EntertainerScore;
    public float MountainKingScore;
    public float HotCrossScoreHigh;
    public float TwinkleTwinkleScoreHigh;
    public float CanonScoreHigh;
    public float EliseScoreHigh;
    public float EntertainerScoreHigh;
    public float MountainKingScoreHigh;
    private NoteStreakControllerScript Info;
    public string lastLevelPlayed;
    public static int PlayerMoney = 1000;

    public static int TwinkleStars;
    public static int CrossStars;
    public static int CanonStars;
    public static int EliseStars;
    public static int EntertainerStars;
    public static int MountainKingStars;
    public Results_StarControlScript Stars;
    GameObject StarToEnable;
    

    void Awake()
    {
        DontDestroyOnLoad( this.gameObject );
    }
    
	void Start()
    {
        HotCrossScore = 0;
        TwinkleTwinkleScore = 0;
        CanonScore = 0;
        EliseScore = 0;
        EntertainerScore = 0;
        MountainKingScore = 0;
        HotCrossScoreHigh = 0;
        TwinkleTwinkleScoreHigh = 0;
        CanonScoreHigh = 0;
        EliseScoreHigh = 0;
        EntertainerScoreHigh = 0;
        MountainKingScoreHigh = 0;
	}
	
	void Update()
    {
        // Cap the player's money at 999,999
        if( PlayerMoney > 999999 )
        {
            PlayerMoney = 999999;
        }

        //checks to see the player's highest score, and if the new score is higher than that
        if (Application.loadedLevelName == "HotCrossBuns")
        {
            lastLevelPlayed = "Hot Cross Buns";
            HotCrossScore = NoteStreakControllerScript.Score;
        }

        if( Application.loadedLevelName == "Main" )
        {
            lastLevelPlayed = "Twinkle Twinkle Little Star";
            TwinkleTwinkleScore = NoteStreakControllerScript.Score;
        }

        if( Application.loadedLevelName == "CanonInD" )
        {
            lastLevelPlayed = "Canon in D Minor";
            CanonScore = NoteStreakControllerScript.Score;
        }

        if( Application.loadedLevelName == "FurElise" )
        {
            lastLevelPlayed = "Fur Elise";
            EliseScore = NoteStreakControllerScript.Score;
        }

        if( Application.loadedLevelName == "TheEntertainer" )
        {
            lastLevelPlayed = "The Entertainer";
            EntertainerScore = NoteStreakControllerScript.Score;
        }

        if (Application.loadedLevelName == "MountainKing")
        {
            lastLevelPlayed = "In the Hall of the Mountain King";
            MountainKingScore = NoteStreakControllerScript.Score;
        }

        if (Application.loadedLevelName == "Results")
        {
            if (lastLevelPlayed == "Hot Cross Buns")
            {
                if (CrossStars < 3)
                {
                    if( Results_StarControlScript.StarLevel == 3 )
                    {
                        CrossStars = 3;
                    }

                    else if( (Results_StarControlScript.StarLevel == 2) && (CrossStars < Results_StarControlScript.StarLevel) )
                    {
                        CrossStars = 2;
                    }

                    else if( (Results_StarControlScript.StarLevel == 1) && (CrossStars < Results_StarControlScript.StarLevel) )
                    {
                        CrossStars = 1;
                    }
                }
            }

            if( lastLevelPlayed == "Twinkle Twinkle Little Star" )
            {
                if( TwinkleStars < 3 )
                {
                    if( Results_StarControlScript.StarLevel == 3 )
                    {
                        TwinkleStars = 3;
                    }

                    else if( (Results_StarControlScript.StarLevel == 2) && (TwinkleStars < Results_StarControlScript.StarLevel) )
                    {
                        TwinkleStars = 2;
                    }

                    else if( (Results_StarControlScript.StarLevel == 1) && (TwinkleStars < Results_StarControlScript.StarLevel) )
                    {
                        TwinkleStars = 1;
                    }
                }
            }

            if( lastLevelPlayed == "Canon in D Minor" )
            {
                if( CanonStars < 3 )
                {
                    if( Results_StarControlScript.StarLevel == 3 )
                    {
                        CanonStars = 3;
                    }

                    else if( (Results_StarControlScript.StarLevel == 2) && (CanonStars < Results_StarControlScript.StarLevel) )
                    {
                        CanonStars = 2;
                    }

                    else if( (Results_StarControlScript.StarLevel == 1) && (CanonStars < Results_StarControlScript.StarLevel) )
                    {
                        CanonStars = 1;
                    }
                }
            }

            if( lastLevelPlayed == "Fur Elise" )
            {
                if( EliseStars < 3 )
                {
                    if( Results_StarControlScript.StarLevel == 3 )
                    {
                        EliseStars = 3;
                    }

                    else if( (Results_StarControlScript.StarLevel == 2) && (EliseStars < Results_StarControlScript.StarLevel) )
                    {
                        EliseStars = 2;
                    }

                    else if( (Results_StarControlScript.StarLevel == 1) && (EliseStars < Results_StarControlScript.StarLevel) )
                    {
                        EliseStars = 1;
                    }
                }
            }

            if( lastLevelPlayed == "The Entertainer" )
            {
                if( EntertainerStars < 3 )
                {
                    if( Results_StarControlScript.StarLevel == 3 )
                    {
                        EntertainerStars = 3;
                    }

                    else if( (Results_StarControlScript.StarLevel == 2) && (EntertainerStars < Results_StarControlScript.StarLevel) )
                    {
                        EntertainerStars = 2;
                    }

                    else if( (Results_StarControlScript.StarLevel == 1) && (EntertainerStars < Results_StarControlScript.StarLevel) )
                    {
                        EntertainerStars = 1;
                    }
                }
            }

            if (lastLevelPlayed == "In the Hall of the Mountain King")
            {
                if (MountainKingStars < 3)
                {
                    if (Results_StarControlScript.StarLevel == 3)
                    {
                        MountainKingStars = 3;
                    }

                    else if ((Results_StarControlScript.StarLevel == 2) && (MountainKingStars < Results_StarControlScript.StarLevel))
                    {
                        MountainKingStars = 2;
                    }

                    else if ((Results_StarControlScript.StarLevel == 1) && (MountainKingStars < Results_StarControlScript.StarLevel))
                    {
                        MountainKingStars = 1;
                    }
                }
            }
        }
	}
}