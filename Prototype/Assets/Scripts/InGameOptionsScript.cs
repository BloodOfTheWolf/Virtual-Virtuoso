using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InGameOptionsScript : MonoBehaviour 
{
    public Button OptionsButton;
    public GameObject OptionsPanel;
    public GameObject OptionsSettingsPanel;
    public Button OptionsSettingsConfirm;
    public Button OptionsSettingsCancel;

    public GameObject OptionsBackgroundPanel;
    public Button OptionsBackgroundButton;
    public GameObject OptionsSettingsBackgroundPanel;
    public Button OptionsSettingsBackgroundButton;


	void Start()
    {
        OptionsPanel.SetActive(false);
        OptionsSettingsPanel.SetActive(false);
	}
	
	public void OptionsPressed() 
    {
        if (OptionsPanel.activeSelf == false)
        {
            OptionsButton.interactable = false;
            Time.timeScale = 0.0f;
            OptionsPanel.SetActive(true);
        }
	}

    public void ResumePressed()
    {
        OptionsPanel.SetActive(false);
        Time.timeScale = 1.0f;
        OptionsButton.interactable = true;
    }

    public void RetryPressed()
    {
        Time.timeScale = 1.0f;
        Application.LoadLevel( Application.loadedLevelName );
    }

    public void SettingsPressed()
    {
        if( OptionsSettingsPanel.activeSelf == false )
        {
            //OptionsButton.interactable = false;
            //Time.timeScale = 0.0f;
            OptionsSettingsPanel.SetActive( true );
            OptionsBackgroundButton.interactable = false;
        }
    }

    public void QuitPressed()
    {
        Time.timeScale = 1.0f;
        Application.LoadLevel( "SongSelectionMenu" );
    }

    public void SettingsConfirmPressed()
    {
        OptionsSettingsPanel.SetActive(false);
        //Time.timeScale = 1.0f;
        //OptionsButton.interactable = true;
        OptionsBackgroundButton.interactable = true;
    }
}
