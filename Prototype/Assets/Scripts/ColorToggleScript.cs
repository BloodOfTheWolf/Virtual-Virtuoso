using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColorToggleScript : MonoBehaviour
{
    public GameObject SaveDataObj;
    public SaveDataScript SaveDataScript;

    public static bool Toggle;

    public Image ColorToggleSprite;
    public Sprite ToggleOn;
    public Sprite ToggleOff;
	
	void Start()
    {
        SaveDataObj = GameObject.Find( "SaveData" );
        SaveDataScript = SaveDataObj.GetComponent<SaveDataScript>();

        UpdateButtonImage();

        ColorToggleSprite = GetComponent<Image>();
	}

    void Update()
    {
        UpdateButtonImage();
    }

    public void UpdateButtonImage()
    {
        if( SaveDataScript.bNoteColorModeEnabled )
        {
            Toggle = true;
            ColorToggleSprite.sprite = ToggleOn;
        }
        else
        {
            Toggle = false;
            ColorToggleSprite.sprite = ToggleOff;
        }
    }
}
