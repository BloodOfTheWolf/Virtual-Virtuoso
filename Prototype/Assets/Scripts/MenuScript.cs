using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour
{

	public Canvas quitMenu;
    public Canvas options;
    public Canvas musicSets;
    public Canvas soundSets;

	public Button startText;
	public Button marketText;
	public Button optionsText;
	public Button exitText;

    public Button OptionsConfirmButton;
    public Button OptionsCancelButton;
    public Button MusicSetsConfirmButton;
    public Button MusicSetsCancelButton;
    public Button SoundSetsConfirmButton;
    public Button SoundSetsCancelButton;

    GameObject SFXController;

	// Use this for initialization
	void Start()
    {
	
		quitMenu = quitMenu.GetComponent<Canvas>();
		options = options.GetComponent<Canvas>();
		startText = startText.GetComponent<Button>();
		marketText = marketText.GetComponent<Button>();
		optionsText = optionsText.GetComponent<Button>();
		exitText = exitText.GetComponent<Button>();
		quitMenu.enabled = false;
        options.enabled = false;
        musicSets.enabled = false;
        soundSets.enabled = false;
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

	public void OptionsButtonPress(string NewMenu)
	{
        Debug.Log( "MenuScript.OptionsButtonPress(" + NewMenu + "): Entered" );
        //SFXController.GetComponent<SFXControllerScript>().ButtonPressed();
        options.enabled = true;

        switch( NewMenu )
        {
        case "Options":
            Debug.Log( "Options entered" );
		    options.enabled = true;
            musicSets.enabled = false;
            soundSets.enabled = false;
            startText.enabled = false;
            marketText.enabled = false;
            optionsText.enabled = false;
            exitText.enabled = false;
        break;
        case "MusicSets":
            options.enabled = false;
            musicSets.enabled = true;
            soundSets.enabled = false;
            startText.enabled = false;
            marketText.enabled = false;
            optionsText.enabled = false;
            exitText.enabled = false;
        break;
        case "SoundSets":
            options.enabled = false;
            musicSets.enabled = false;
            soundSets.enabled = true;
            startText.enabled = false;
            marketText.enabled = false;
            optionsText.enabled = false;
            exitText.enabled = false;
        break;
        }
	}
	
	public void AcceptButtonPress(string ActiveMenu)
    {
        Debug.Log( "MenuScript.AcceptButtonPress(" + ActiveMenu + "): Entered" );
        SFXController.GetComponent<SFXControllerScript>().OptionAccepted();

        switch( ActiveMenu )
        {
        case "Options":
		    options.enabled = false;
            musicSets.enabled = false;
            soundSets.enabled = false;
		    startText.enabled = true;
		    marketText.enabled = true;
		    optionsText.enabled = true;
		    exitText.enabled = true;
        break;
        case "MusicSets":
            options.enabled = true;
            musicSets.enabled = false;
            soundSets.enabled = false;
            startText.enabled = false;
            marketText.enabled = false;
            optionsText.enabled = false;
            exitText.enabled = false;
        break;
        case "SoundSets":
            options.enabled = true;
            musicSets.enabled = false;
            soundSets.enabled = false;
            startText.enabled = false;
            marketText.enabled = false;
            optionsText.enabled = false;
            exitText.enabled = false;
        break;
        }
	}

    public void BackButtonPress(string ActiveMenu)
    {
        Debug.Log( "MenuScript.BackButtonPress(" + ActiveMenu + "): Entered" );
        SFXController.GetComponent<SFXControllerScript>().QuitButtonPressed();

        switch( ActiveMenu )
        {
        case "Options":
		    options.enabled = false;
            musicSets.enabled = false;
            soundSets.enabled = false;
		    startText.enabled = true;
		    marketText.enabled = true;
		    optionsText.enabled = true;
		    exitText.enabled = true;
        break;
        case "MusicSets":
            options.enabled = true;
            musicSets.enabled = false;
            soundSets.enabled = false;
            startText.enabled = false;
            marketText.enabled = false;
            optionsText.enabled = false;
            exitText.enabled = false;
        break;
        case "SoundSets":
            options.enabled = true;
            musicSets.enabled = false;
            soundSets.enabled = false;
            startText.enabled = false;
            marketText.enabled = false;
            optionsText.enabled = false;
            exitText.enabled = false;
        break;
        }
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
