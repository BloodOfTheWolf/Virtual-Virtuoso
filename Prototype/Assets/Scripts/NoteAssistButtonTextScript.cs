using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NoteAssistButtonTextScript : MonoBehaviour
{
    public GameObject SaveDataObj;
    public SaveDataScript SaveDataScript;
    public GameObject ButtonText;

	void Start()
    {
        SaveDataObj = GameObject.Find( "SaveData" );
        SaveDataScript = SaveDataObj.GetComponent<SaveDataScript>();

        UpdateButtonText();
	}

    void Update()
    {
        UpdateButtonText();
    }

    public void UpdateButtonText()
    {
        if( SaveDataScript.bNoteAssistModeEnabled )
        {
            ButtonText.GetComponent<Text>().text = "Note Assist Mode ON";
        }
        else
        {
            ButtonText.GetComponent<Text>().text = "Note Assist Mode OFF";
        }
    }
}
