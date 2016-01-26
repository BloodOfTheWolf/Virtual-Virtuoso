using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerScoreInfoScript : MonoBehaviour {

    public float MaryLambScore;
    public float HotCrossScore;
    public float TwinkleTwinkleScore;
    public float CanonScore;
    public float EliseScore;
    public float EntertainerScore;
    public float MaryLambScoreHigh;
    public float HotCrossScoreHigh;
    public float TwinkleTwinkleScoreHigh;
    public float CanonScoreHigh;
    public float EliseScoreHigh;
    public float EntertainerScoreHigh;
    private SheetNoteScript Info;
    public string lastLevelPlayed;
    public static int PlayerMoney = 200;
    
    void Awake()
    {
        DontDestroyOnLoad( this.gameObject );
    }
    
    // Use this for initialization
	void Start () 
    {
        MaryLambScore = 0;
        HotCrossScore = 0;
        TwinkleTwinkleScore = 0;
        CanonScore = 0;
        EliseScore = 0;
        EntertainerScore = 0;
        MaryLambScoreHigh = 0;
        HotCrossScoreHigh = 0;
        TwinkleTwinkleScoreHigh = 0;
        CanonScoreHigh = 0;
        EliseScoreHigh = 0;
        EntertainerScoreHigh = 0;
        
	}
	
	// Update is called once per frame
	void Update () 
    {
        //checks to see the player's highest score, and if the new score is higher than that
        if( Application.loadedLevelName == "MaryLamb" )
        {
            lastLevelPlayed = "Mary Had a Little Lamb";
            MaryLambScore = SheetNoteScript.Score;
        }
        
        if (Application.loadedLevelName == "HotCrossBuns")
        {
            lastLevelPlayed = "Hot Cross Buns";
            HotCrossScore = SheetNoteScript.Score;
        }

        if( Application.loadedLevelName == "Main" )
        {
            lastLevelPlayed = "Twinkle Twinkle Little Star";
            TwinkleTwinkleScore = SheetNoteScript.Score;
        }

        if( Application.loadedLevelName == "CanonInD" )
        {
            lastLevelPlayed = "Canon in D Minor";
            CanonScore = SheetNoteScript.Score;
        }

        if( Application.loadedLevelName == "FurElise" )
        {
            lastLevelPlayed = "Fur Elise";
            EliseScore = SheetNoteScript.Score;
        }

        if( Application.loadedLevelName == "TheEntertainer" )
        {
            lastLevelPlayed = "The Entertainer";
            EntertainerScore = SheetNoteScript.Score;
        }
	}
}