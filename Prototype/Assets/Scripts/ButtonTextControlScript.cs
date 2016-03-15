using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonTextControlScript : MonoBehaviour
{

    //add public variable for each button we need in the song selection menu
    public Button StartButton;
    public Button BackButton;
    public Button TutorialButton;
    public Button HotCrossBunsButton;
    public Button FurEliseButton;
    public Button CanonInDButton;
    public Button EntertainerButton;
    public Button MountainKingButton;
    public Button FreeplayButton;
    public Text TutorialComposer;
    public Text HotCrossBunsComposer;
    public Text FurEliseComposer;
    public Text CanonInDComposer;
    public Text EntertainerComposer;
    public Text MountainKingComposer;
    public Text FreeplayComposer;

	// Use this for initialization
	void Start ()
    {
        TutorialButton.GetComponentInChildren<Text>().text          = "Twinkle Twinkle Little Star (Tutorial)";
        HotCrossBunsButton.GetComponentInChildren<Text>().text      = "Hot Cross Buns";
        FurEliseButton.GetComponentInChildren<Text>().text          = "Für Elise";
        CanonInDButton.GetComponentInChildren<Text>().text          = "Canon In D";
        EntertainerButton.GetComponentInChildren<Text>().text       = "The Entertainer";
        MountainKingButton.GetComponentInChildren<Text>().text      = "In the Hall of the Mountain King";
        FreeplayButton.GetComponentInChildren<Text>().text          = "Freeplay Mode";
        TutorialComposer.text       = "Jane Taylor (1806)";
        HotCrossBunsComposer.text   = "Traditional (1798)";
        FurEliseComposer.text       = "Ludwig van Beethoven (1867)";
        CanonInDComposer.text       = "Johann Pachelbel (1680)";
        EntertainerComposer.text    = "John Stark & Son (1902)";
        MountainKingComposer.text   = "Edward Grieg (1876)";
        FreeplayComposer.text       = "N/A";
		//BackButton.GetComponentInChildren<Text>().text = "Back";
	}

	public void BackButtonPress()
	{
		Application.LoadLevel("MainMenu");
	}

}
