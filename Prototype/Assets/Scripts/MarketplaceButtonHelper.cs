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

    /// <summary>
    /// The numeric index of this set.
    /// </summary>
    public int SetIndex = 0;

    /// <summary>
    /// This set's shorthand name.
    /// </summary>
    public string SetShortName;

    /// <summary>
    /// This set's long name.
    /// </summary>
    public string SetLongName;
    public int SetPrice = 0;
    public string MusicSetSoundPath;
    public bool MusicSetBought;

    public Toggle SetToggle;
    public Text PriceText;

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
            SetToggle.interactable = false;
            this.GetComponent<Button>().interactable = true;
            PriceText.text = SetPrice.ToString();
            break;
        case ButtonState.NotAvailable:
            gameObject.GetComponent<Image>().sprite = NotAvailableImage;
            SetToggle.interactable = false;
            this.GetComponent<Button>().interactable = false;
            PriceText.text = "N/A";
            break;
        case ButtonState.Purchased:
            //gameObject.GetComponent<Image>().sprite = PurchasedImage;
            SetToggle.interactable = true;
            this.GetComponent<Button>().interactable = false;
            PriceText.text = "PURCHASED";
            break;
        }
    }

    public void SetButtonState( ButtonState newButtonState )
    {
        currentButtonState = newButtonState;
    }
}
