using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonTextControlScript : MonoBehaviour {

    //add public variable for each button we need in the song selection menu
    public Button StartButton;
    public Button BackButton;
    public Button TutorialButton;
    public Button HotCrossBunsButton;
    public Button MaryLambButton;
    public Button FurEliseButton;
    public Button CanonInDButton;
    public Button EntertainerButton;

	// Use this for initialization
	void Start ()
    {
        TutorialButton.GetComponentInChildren<Text>().text          = "\"Twinkle Twinkle Little Star (Tutorial)\" \u2014 Jane Taylor (1806)";
        HotCrossBunsButton.GetComponentInChildren<Text>().text      = "\"Hot Cross Buns\" \u2014 Traditional (1798)";
        MaryLambButton.GetComponentInChildren<Text>().text          = "\"Mary Had a Little Lamb\" \u2014 Sarah Josepha Hale (1830)";
        FurEliseButton.GetComponentInChildren<Text>().text          = "\"Für Elise\" \u2014 Ludwig van Beethoven (1867)";
        CanonInDButton.GetComponentInChildren<Text>().text          = "\"Canon In D\" \u2014 Johann Pachelbel (1680)";
        EntertainerButton.GetComponentInChildren<Text>().text       = "\"The Entertainer\" \u2014 John Stark & Son (1902)";
		//BackButton.GetComponentInChildren<Text>().text = "Back";
	}

	public void BackButtonPress()
	{
		Application.LoadLevel("MainMenu");
	}
}
