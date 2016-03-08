using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonTextAndControlScript : MonoBehaviour {

	//add public variable for each button we need in the song selection menu
	public Button BackButton;
    public Button Tutorial_Button;
    public Button HotCrossBuns_Button;
    public Button FurElise_Button;
    public Button CanonInD_Button;
    public Button Entertainer_Button;
    public Button Tutorial_Composer;
    public Button HotCrossBuns_Composer;
    public Button FurElise_Composer;
    public Button CanonInD_Composer;
    public Button Entertainer_Composer;
	public Button StartButton;
	public int roomSelected = 0;

	// Use this for initialization
	void Start ()
    {
        Tutorial_Button.GetComponentInChildren<Text>().text         = "Twinkle Twinkle Little Star (Tutorial)";
        HotCrossBuns_Button.GetComponentInChildren<Text>().text     = "Hot Cross Buns";
        FurElise_Button.GetComponentInChildren<Text>().text         = "Für Elise";
        CanonInD_Button.GetComponentInChildren<Text>().text         = "Canon In D";
        Entertainer_Button.GetComponentInChildren<Text>().text      = "The Entertainer";
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
