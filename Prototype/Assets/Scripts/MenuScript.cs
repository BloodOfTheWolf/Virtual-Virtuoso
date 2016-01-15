using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public Canvas quitMenu;
	public Canvas soundOptions;
	public Button startText;
	public Button marketText;
	public Button optionsText;
	public Button exitText;

    GameObject SFXController;

	// Use this for initialization
	void Start () {
	
		quitMenu = quitMenu.GetComponent<Canvas> ();
		soundOptions = soundOptions.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		marketText = marketText.GetComponent<Button> ();
		optionsText = optionsText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		quitMenu.enabled = false;
		soundOptions.enabled = false;

	}

    void Update()
    {
        SFXController = GameObject.Find( "SFXController" );
    }
	
	public void ExitButtonPress()
	{
        SFXController.GetComponent<SFXControllerScript>().QuitButtonPressed();
		quitMenu.enabled = true;
		startText.enabled = false;
		marketText.enabled = false;
		optionsText.enabled = false;
		exitText.enabled = false;
	}

	public void NoButtonPress()
	{
        SFXController.GetComponent<SFXControllerScript>().ButtonPressed();
		quitMenu.enabled = false;
		startText.enabled = true;
		marketText.enabled = true;
		optionsText.enabled = true;
		exitText.enabled = true;
	}

	public void OptionsButtonPress()
	{
        SFXController.GetComponent<SFXControllerScript>().ButtonPressed();
		soundOptions.enabled = true;
		startText.enabled = false;
		marketText.enabled = false;
		optionsText.enabled = false;
		exitText.enabled = false;
	}
	
	public void AcceptButtonPress()
	{
        SFXController.GetComponent<SFXControllerScript>().OptionAccepted();
		soundOptions.enabled = false;
		startText.enabled = true;
		marketText.enabled = true;
		optionsText.enabled = true;
		exitText.enabled = true;
	}

    public void BackButtonPress()
    {
        SFXController.GetComponent<SFXControllerScript>().QuitButtonPressed();
        soundOptions.enabled = false;
        startText.enabled = true;
        marketText.enabled = true;
        optionsText.enabled = true;
        exitText.enabled = true;
    }

	public void GoToSongSelect()
	{
		Application.LoadLevel(1);
	}

	public void GoToMarket()
	{
		Application.LoadLevel(8);
	}

	public void GameExit()
	{
		Application.Quit();
		//UnityEditor.EditorApplication.isPlaying = false;
	}
}
