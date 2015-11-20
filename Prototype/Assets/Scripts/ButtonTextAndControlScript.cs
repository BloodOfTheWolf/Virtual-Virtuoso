using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonTextAndControlScript : MonoBehaviour {

	//add public variable for each button we need in the song selection menu
	public Button BackButton;
	public Button TutorialButton;
	public Button StartButton;
	public int roomSelected = 0;

	// Use this for initialization
	void Start () {
	
		TutorialButton.GetComponentInChildren<Text>().text = "Twinkle Twinkle Little Star (Tutorial)";
		//BackButton.GetComponentInChildren<Text>().text = "Back";
		StartButton.GetComponentInChildren<Text>().text = "Start";
	}

	public void BackButtonPress()
	{
		Application.LoadLevel (0);
	}

	public void TutorialSelected()
	{
		roomSelected = 1;
	}

	public void GameStart()
	{
		if (roomSelected == 1) {
			Application.LoadLevel(2);
		}
	}
}
