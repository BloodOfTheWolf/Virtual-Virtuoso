using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MarketplaceButtonController : MonoBehaviour
{
	
	public Canvas marketMenu;
	public Button soundSetButton;
	public Button bgMusicButton;
	public Button backButton;

    GameObject SFXController;
	
	// Use this for initialization
	void Start ()
    {
		marketMenu = marketMenu.GetComponent<Canvas> ();
		soundSetButton = soundSetButton.GetComponent<Button> ();
		bgMusicButton = bgMusicButton.GetComponent<Button> ();
		backButton = backButton.GetComponent<Button> ();		
	}

    void Update()
    {
        SFXController = GameObject.Find( "SFXController" );
    }
	
	public void BackButtonPress()
	{
        SFXController.GetComponent<SFXControllerScript>().QuitButtonPressed();
		Application.LoadLevel( "MainMenu" );
	}
	
	public void SoundSetSelect()
	{
        SFXController.GetComponent<SFXControllerScript>().ButtonPressed();
		Application.LoadLevel( "SoundSetSelectionMenu" );
	}
	
	public void BGMusicSelect()
	{
        SFXController.GetComponent<SFXControllerScript>().ButtonPressed();
		Application.LoadLevel( "BackgroundMusicSelectionMenu" );
		//UnityEditor.EditorApplication.isPlaying = false;
	}
}