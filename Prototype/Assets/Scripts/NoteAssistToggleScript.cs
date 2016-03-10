using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NoteAssistToggleScript : MonoBehaviour
{
    public GameObject SaveDataObj;
    public SaveDataScript SaveDataScript;

    public static bool Toggle;

    public Image AssistToggleSprite;
    public Sprite ToggleOn;
    public Sprite ToggleOff;

	void Start()
    {
        SaveDataObj = GameObject.Find( "SaveData" );
        SaveDataScript = SaveDataObj.GetComponent<SaveDataScript>();

        UpdateButtonImage();

        AssistToggleSprite = GetComponent<Image>();
	}

    void Update()
    {
        UpdateButtonImage();
    }

    public void UpdateButtonImage()
    {
        if( SaveDataScript.bNoteAssistModeEnabled )
        {
            Toggle = true;
            AssistToggleSprite.sprite = ToggleOn;
        }
        else
        {
            Toggle = false;
            AssistToggleSprite.sprite = ToggleOff;
        }
    }
}
