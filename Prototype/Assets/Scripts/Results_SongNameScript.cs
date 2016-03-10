using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Results_SongNameScript : MonoBehaviour {

    private PlayerScoreInfoScript Info;
    GameObject PlayerInfo;
    public Text canvasText;
    public string LastLevel;

	// Use this for initialization
	void Start() 
    {
        PlayerInfo = GameObject.Find( "PlayerInfoHolder" );
        LastLevel = PlayerInfo.GetComponent<PlayerScoreInfoScript>().lastLevelPlayed;
	}
	
	// Update is called once per frame
	void Update() 
    {
        canvasText.text = (PlayerInfo.GetComponent<PlayerScoreInfoScript>().lastLevelPlayed).ToUpper();
	}
    void LastLevelPlayed()
    {
        switch(LastLevel)
        {
        case "Hot Cross Buns":
        
        break;
        case "Twinkle Twinkle Little Star":
        break;
        }
    }
}
