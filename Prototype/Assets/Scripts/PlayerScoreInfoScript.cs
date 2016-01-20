using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerScoreInfoScript : MonoBehaviour {

    public float MaryLambScore;
    public float HotCrossScore;
    public float MaryLambScoreHigh;
    public float HotCrossScoreHigh;
    private SheetNoteScript Info;
    public string lastLevelPlayed;
    
    void Awake()
    {
        DontDestroyOnLoad( this.gameObject );
    }
    
    // Use this for initialization
	void Start () 
    {
        MaryLambScore = 0;
        HotCrossScore = 0;
        MaryLambScoreHigh = 0;
        HotCrossScoreHigh = 0;
	}
	
	// Update is called once per frame
	void Update () 
    {
        //checks to see the player's highest score, and if the new score is higher than that
        if( Application.loadedLevelName == "MaryLamb" )
        {
            lastLevelPlayed = "MaryLamb";
            MaryLambScore = SheetNoteScript.Score;
        }
        
        if (Application.loadedLevelName == "HotCrossBuns")
        {
            lastLevelPlayed = "HotCrossBuns";
            HotCrossScore = SheetNoteScript.Score;
        }
	}
}