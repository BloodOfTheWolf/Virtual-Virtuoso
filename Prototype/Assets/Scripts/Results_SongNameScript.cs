using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Results_SongNameScript : MonoBehaviour {

    private PlayerScoreInfoScript Info;
    GameObject PlayerInfo;
    public Text canvasText;

	// Use this for initialization
	void Start () 
    {
        PlayerInfo = GameObject.Find( "PlayerInfoHolder" );
	}
	
	// Update is called once per frame
	void Update () 
    {
        canvasText.text = (PlayerInfo.GetComponent<PlayerScoreInfoScript>().lastLevelPlayed);
	}
}
