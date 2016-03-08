using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MarketplaceButtonHelper : MonoBehaviour
{
    BGMusicSetController ControllerObjectScript;
    GameObject SaveDataObj;
    SaveDataScript SaveDataObjScript;

    public Sprite AvailableImage;
    public Sprite NotAvailableImage;
    public Sprite PurchasedImage;

    public enum ButtonState
    {
        Available,
        NotAvailable,
        Purchased
    };

    public ButtonState currentButtonState = ButtonState.Available;

    void Start()
    {
        ControllerObjectScript = GameObject.Find( "BGMusicMenu" ).GetComponent<BGMusicSetController>();
        SaveDataObj = GameObject.Find( "SaveData" );
        SaveDataObjScript = SaveDataObj.GetComponent<SaveDataScript>();
    }

    void Update()
    {
        switch( currentButtonState )
        {
        case ButtonState.Available:
            gameObject.GetComponent<Image>().sprite = AvailableImage;
            SaveDataObjScript.MusicSetOneState = 0;
            break;
        case ButtonState.NotAvailable:
            gameObject.GetComponent<Image>().sprite = NotAvailableImage;
            break;
        case ButtonState.Purchased:
            gameObject.GetComponent<Image>().sprite = PurchasedImage;
            break;
        }
    }

    public void SetButtonState( ButtonState newButtonState )
    {
        currentButtonState = newButtonState;
    }
}
