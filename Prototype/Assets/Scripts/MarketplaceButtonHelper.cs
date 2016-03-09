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

    public Toggle SetToggle;
    public Text PriceText;
    public int Price = 0;

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
            PriceText.text = Price.ToString();
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
