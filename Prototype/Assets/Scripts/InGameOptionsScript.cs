using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InGameOptionsScript : MonoBehaviour 
{
    public Button OptionsButton;
    public Canvas OptionsTab;
	// Use this for initialization
	void Start () 
    {
        OptionsTab.enabled = false;
	}
	
	// Update is called once per frame
	public void OptionsPressed () 
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
        Application.LoadLevel( Application.loadedLevelName );
    }

    public void SettingsPressed()
    {

    }

    public void QuitPressed()
    {
        Application.LoadLevel( 5 );
    }
}
