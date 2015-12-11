using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MarketplaceButtonController : MonoBehaviour
{
	
	public Canvas marketMenu;
	public Button soundSetButton;
	public Button bgMusicButton;
	public Button backButton;
	
	// Use this for initialization
	void Start ()
    {
		marketMenu = marketMenu.GetComponent<Canvas> ();
		soundSetButton = soundSetButton.GetComponent<Button> ();
		bgMusicButton = bgMusicButton.GetComponent<Button> ();
		backButton = backButton.GetComponent<Button> ();		
	}
	
	public void BackButtonPress()
	{
		Application.LoadLevel( "MainMenu" );
	}
	
	public void SoundSetSelect()
	{
		Application.LoadLevel( "SoundSetSelectionMenu" );
	}
	
	public void BGMusicSelect()
	{
		Application.LoadLevel( "BackgroundMusicSelectionMenu" );
		//UnityEditor.EditorApplication.isPlaying = false;
	}
}