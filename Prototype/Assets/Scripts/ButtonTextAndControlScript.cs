using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonTextAndControlScript : MonoBehaviour {

	//add public variable for each button we need in the song selection menu
	public Button BackButton;
    public Button Tutorial_Button;
    public Button HotCrossBuns_Button;
    public Button MaryLamb_Button;
    public Button FurElise_Button;
    public Button CanonInD_Button;
    public Button Entertainer_Button;
	public Button StartButton;
	public int roomSelected = 0;

	// Use this for initialization
    void Start()
    {
        Tutorial_Button.GetComponentInChildren<Text>().text = "Twinkle Twinkle Little Star (Tutorial)";
		HotCrossBuns_Button.GetComponentInChildren<Text>().text     = "Hot Cross Buns";
        MaryLamb_Button.GetComponentInChildren<Text>().text         = "Mary Had a Little Lamb";
        FurElise_Button.GetComponentInChildren<Text>().text         = "Für Elise";
        CanonInD_Button.GetComponentInChildren<Text>().text         = "Canon In D";
        Entertainer_Button.GetComponentInChildren<Text>().text      = "The Entertainer";		StartButton.GetComponentInChildren<Text>().text = "Start";
	}

	public void BackButtonPress()
	{
		Application.LoadLevel (0);
	}

	public void TutorialSelected()
	{
		roomSelected = 1;
	}
	public void HotCrossBunsSelected()
	{
		roomSelected = 2;
	}
	public void MaryLambSelected()
	{
		roomSelected = 3;
	}
	public void FurEliseSelected()
	{
		roomSelected = 4;
	}
	public void CanonInDSelected()
	{
		roomSelected = 5;
	}
	public void EntertainerSelected()
	{
		roomSelected = 6;
	}

	public void GameStart()
	{
        Destroy( GameObject.Find( "Songholder" ) );
		if (roomSelected == 1) {
			Application.LoadLevel(2);
		}
		if (roomSelected == 2) {
			Application.LoadLevel(3);
		}
		if (roomSelected == 3) {
			Application.LoadLevel(4);
		}
		if (roomSelected == 4) {
			Application.LoadLevel(5);
		}
		if (roomSelected == 5) {
			Application.LoadLevel(6);
		}
		if (roomSelected == 6) {
			Application.LoadLevel(7);
		}
	}
}
