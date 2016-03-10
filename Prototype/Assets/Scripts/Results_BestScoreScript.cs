using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Results_BestScoreScript : MonoBehaviour 
{
    private PlayerScoreInfoScript Info;
    float HotCrossScoreHigh;
    float TwinkleTwinkleScoreHigh;
    float CanonScoreHigh;
    float EliseScoreHigh;
    float EntertainerScoreHigh;
    GameObject PlayerInfo;
    Text BestText;

    void Awake()
    {
        DontDestroyOnLoad( this.gameObject );
    }

	// Use this for initialization
	void Start () 
    {
        PlayerInfo = GameObject.Find( "PlayerInfoHolder" );
        BestText = GetComponent<Text>();
        BestText.text = ("This is where the best score should be");
	}
	
	// Update is called once per frame
	void Update () 
    {
        //check last level played, and then check the new score against the player's current highest
        if( PlayerInfo.GetComponent<PlayerScoreInfoScript>().lastLevelPlayed == "Hot Cross Buns" )
        {
            if( PlayerInfo.GetComponent<PlayerScoreInfoScript>().HotCrossScore > PlayerInfo.GetComponent<PlayerScoreInfoScript>().HotCrossScoreHigh )
            {
                PlayerInfo.GetComponent<PlayerScoreInfoScript>().HotCrossScoreHigh = PlayerInfo.GetComponent<PlayerScoreInfoScript>().HotCrossScore;
            }
            BestText.text = ("BEST SCORE: " + PlayerInfo.GetComponent<PlayerScoreInfoScript>().HotCrossScoreHigh.ToString( "N0" ));
        }

        if( PlayerInfo.GetComponent<PlayerScoreInfoScript>().lastLevelPlayed == "Twinkle Twinkle Little Star" )
        {
            if( PlayerInfo.GetComponent<PlayerScoreInfoScript>().TwinkleTwinkleScore > PlayerInfo.GetComponent<PlayerScoreInfoScript>().TwinkleTwinkleScoreHigh )
            {
                PlayerInfo.GetComponent<PlayerScoreInfoScript>().TwinkleTwinkleScoreHigh = PlayerInfo.GetComponent<PlayerScoreInfoScript>().TwinkleTwinkleScore;
            }
            BestText.text = ("BEST SCORE: " + PlayerInfo.GetComponent<PlayerScoreInfoScript>().TwinkleTwinkleScoreHigh.ToString( "N0" ));
        }

        if( PlayerInfo.GetComponent<PlayerScoreInfoScript>().lastLevelPlayed == "Canon in D Minor" )
        {
            if( PlayerInfo.GetComponent<PlayerScoreInfoScript>().CanonScore > PlayerInfo.GetComponent<PlayerScoreInfoScript>().CanonScoreHigh )
            {
                PlayerInfo.GetComponent<PlayerScoreInfoScript>().CanonScoreHigh = PlayerInfo.GetComponent<PlayerScoreInfoScript>().CanonScore;
            }
            BestText.text = ("BEST SCORE: " + PlayerInfo.GetComponent<PlayerScoreInfoScript>().CanonScoreHigh.ToString( "N0" ));
        }

        if( PlayerInfo.GetComponent<PlayerScoreInfoScript>().lastLevelPlayed == "Fur Elise" )
        {
            if( PlayerInfo.GetComponent<PlayerScoreInfoScript>().EliseScore > PlayerInfo.GetComponent<PlayerScoreInfoScript>().EliseScoreHigh )
            {
                PlayerInfo.GetComponent<PlayerScoreInfoScript>().EliseScoreHigh = PlayerInfo.GetComponent<PlayerScoreInfoScript>().EliseScore;
            }
            BestText.text = ("BEST SCORE: " + PlayerInfo.GetComponent<PlayerScoreInfoScript>().EliseScoreHigh.ToString( "N0" ));
        }

        if( PlayerInfo.GetComponent<PlayerScoreInfoScript>().lastLevelPlayed == "The Entertainer" )
        {
            if( PlayerInfo.GetComponent<PlayerScoreInfoScript>().EntertainerScore > PlayerInfo.GetComponent<PlayerScoreInfoScript>().EntertainerScoreHigh )
            {
                PlayerInfo.GetComponent<PlayerScoreInfoScript>().EntertainerScoreHigh = PlayerInfo.GetComponent<PlayerScoreInfoScript>().EntertainerScore;
            }
            BestText.text = ("BEST SCORE: " + PlayerInfo.GetComponent<PlayerScoreInfoScript>().EntertainerScoreHigh.ToString( "N0" ));
        }

	}
}
