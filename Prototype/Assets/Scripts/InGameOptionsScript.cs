using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InGameOptionsScript : MonoBehaviour 
{
    public Button OptionsButton;
    public Canvas OptionsTab;
    public GameObject OptionsSettingTab;
    public Button OptionsSettingsConfirm;
    public Button OptionsSettingsCancel;

	void Start()
    {
        OptionsTab.enabled = false;
        OptionsSettingTab.SetActive(false);
	}
	
	public void OptionsPressed() 
    {
        if (OptionsTab.enabled == false)
        {
            OptionsButton.interactable = false;
            Time.timeScale = 0.0f;
            OptionsTab.enabled = true;
        }
	}

    public void ResumePressed()
    {
        OptionsTab.enabled = false;
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
        if( OptionsSettingTab.activeSelf == false )
        {
            //OptionsButton.interactable = false;
            //Time.timeScale = 0.0f;
            OptionsSettingTab.SetActive( true );
            
        }
    }

    public void QuitPressed()
    {
        Time.timeScale = 1.0f;
        Application.LoadLevel( 5 );
    }

    public void SettingsConfirmPressed()
    {
        OptionsSettingTab.SetActive(false);
        //Time.timeScale = 1.0f;
        //OptionsButton.interactable = true;
    }

    
}
