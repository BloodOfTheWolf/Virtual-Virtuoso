using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonTextControlScript : MonoBehaviour {

	//add public variable for each button we need in the song selection menu
	public Button BackButton;
	public Button TutorialButton;

	// Use this for initialization
	void Start () {
	
		TutorialButton.GetComponentInChildren<Text>().text = "Twinkle Twinkle Little Star (Tutorial)";
		BackButton.GetComponentInChildren<Text>().text = "Back";
	}

	public void BackButtonPress()
	{
		Application.LoadLevel (0);
	}

	public void TutorialStart()
	{
		Application.LoadLevel (2);
	}
}
