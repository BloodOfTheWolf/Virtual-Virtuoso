using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Results_BestScoreScript : MonoBehaviour 
{
    private PlayerScoreInfoScript Info;
    float MaryLambScoreHigh;
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
        if( PlayerInfo.GetComponent<PlayerScoreInfoScript>().lastLevelPlayed == "Mary Had a Little Lamb" )
        {
            if( PlayerInfo.GetComponent<PlayerScoreInfoScript>().MaryLambScore > PlayerInfo.GetComponent<PlayerScoreInfoScript>().MaryLambScoreHigh )
            {
                PlayerInfo.GetComponent<PlayerScoreInfoScript>().MaryLambScoreHigh = PlayerInfo.GetComponent<PlayerScoreInfoScript>().MaryLambScore;
            }
            BestText.text = ("Best Score:" + PlayerInfo.GetComponent<PlayerScoreInfoScript>().MaryLambScoreHigh);
        }

        if( PlayerInfo.GetComponent<PlayerScoreInfoScript>().lastLevelPlayed == "Hot Cross Buns" )
        {
            if( PlayerInfo.GetComponent<PlayerScoreInfoScript>().HotCrossScore > PlayerInfo.GetComponent<PlayerScoreInfoScript>().HotCrossScoreHigh )
            {
                PlayerInfo.GetComponent<PlayerScoreInfoScript>().HotCrossScoreHigh = PlayerInfo.GetComponent<PlayerScoreInfoScript>().HotCrossScore;
            }
            BestText.text = ("Best Score:" + PlayerInfo.GetComponent<PlayerScoreInfoScript>().HotCrossScoreHigh);
        }

        if( PlayerInfo.GetComponent<PlayerScoreInfoScript>().lastLevelPlayed == "Twinkle Twinkle Little Star" )
        {
            if( PlayerInfo.GetComponent<PlayerScoreInfoScript>().TwinkleTwinkleScore > PlayerInfo.GetComponent<PlayerScoreInfoScript>().TwinkleTwinkleScoreHigh )
            {
                PlayerInfo.GetComponent<PlayerScoreInfoScript>().TwinkleTwinkleScoreHigh = PlayerInfo.GetComponent<PlayerScoreInfoScript>().TwinkleTwinkleScore;
            }
            BestText.text = ("Best Score:" + PlayerInfo.GetComponent<PlayerScoreInfoScript>().TwinkleTwinkleScoreHigh);
        }

        if( PlayerInfo.GetComponent<PlayerScoreInfoScript>().lastLevelPlayed == "Canon in D Minor" )
        {
            if( PlayerInfo.GetComponent<PlayerScoreInfoScript>().CanonScore > PlayerInfo.GetComponent<PlayerScoreInfoScript>().CanonScoreHigh )
            {
                PlayerInfo.GetComponent<PlayerScoreInfoScript>().CanonScoreHigh = PlayerInfo.GetComponent<PlayerScoreInfoScript>().CanonScore;
            }
            BestText.text = ("Best Score:" + PlayerInfo.GetComponent<PlayerScoreInfoScript>().CanonScoreHigh);
        }

        if( PlayerInfo.GetComponent<PlayerScoreInfoScript>().lastLevelPlayed == "Fur Elise" )
        {
            if( PlayerInfo.GetComponent<PlayerScoreInfoScript>().EliseScore > PlayerInfo.GetComponent<PlayerScoreInfoScript>().EliseScoreHigh )
            {
                PlayerInfo.GetComponent<PlayerScoreInfoScript>().EliseScoreHigh = PlayerInfo.GetComponent<PlayerScoreInfoScript>().EliseScore;
            }
            BestText.text = ("Best Score:" + PlayerInfo.GetComponent<PlayerScoreInfoScript>().EliseScoreHigh);
        }

        if( PlayerInfo.GetComponent<PlayerScoreInfoScript>().lastLevelPlayed == "The Entertainer" )
        {
            if( PlayerInfo.GetComponent<PlayerScoreInfoScript>().EntertainerScore > PlayerInfo.GetComponent<PlayerScoreInfoScript>().EntertainerScoreHigh )
            {
                PlayerInfo.GetComponent<PlayerScoreInfoScript>().EntertainerScoreHigh = PlayerInfo.GetComponent<PlayerScoreInfoScript>().EntertainerScore;
            }
            BestText.text = ("Best Score:" + PlayerInfo.GetComponent<PlayerScoreInfoScript>().EntertainerScoreHigh);
        }

	}
}
