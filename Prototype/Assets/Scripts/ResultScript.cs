using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResultScript : MonoBehaviour {


	private SheetNoteScript Results;
	private int Score;
	// Use this for initialization
	void Start () 
	{

		Score = SheetNoteScript.Score;
		Text ScoreText = GetComponent<Text> ();
		ScoreText.text = Score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
