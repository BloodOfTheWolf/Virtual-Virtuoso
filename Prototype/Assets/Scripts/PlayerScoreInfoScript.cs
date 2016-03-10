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
    public float HotCrossScoreHigh;
    public float TwinkleTwinkleScoreHigh;
    public float CanonScoreHigh;
    public float EliseScoreHigh;
    public float EntertainerScoreHigh;
    private NoteStreakControllerScript Info;
    public string lastLevelPlayed;
    public static int PlayerMoney = 1000;
    
    void Awake()
    {
        DontDestroyOnLoad( this.gameObject );
    }
    
    // Use this for initialization
	void Start () 
    {
        HotCrossScore = 0;
        TwinkleTwinkleScore = 0;
        CanonScore = 0;
        EliseScore = 0;
        EntertainerScore = 0;
        HotCrossScoreHigh = 0;
        TwinkleTwinkleScoreHigh = 0;
        CanonScoreHigh = 0;
        EliseScoreHigh = 0;
        EntertainerScoreHigh = 0;
        
	}
	
	// Update is called once per frame
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
	}
}