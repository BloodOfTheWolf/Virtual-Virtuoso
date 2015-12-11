using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BGMusicSetController : MonoBehaviour {

    //add public variable for each button we need in the song selection menu
    public Button BackButton;
    public Button MusicSetOne;
    public Button MusicSetTwo;
    public Button MusicSetThree;
    public Button MusicSetFour;

    string MusicSelected;
    string PurchaseMessage;

    bool MenuActive = false;

    public Canvas ConfirmPurchase;

    // Use this for initialization
    void Start()
    {
        MusicSetOne.GetComponentInChildren<Text>().text = "MusicSetOne";
        MusicSetTwo.GetComponentInChildren<Text>().text = "MusicSetTwo";
        MusicSetThree.GetComponentInChildren<Text>().text = "MusicSetThree";
        MusicSetFour.GetComponentInChildren<Text>().text = "MusicSetFour";
        BackButton.GetComponentInChildren<Text>().text = "Back";
        MusicSelected = "";
        ConfirmPurchase.enabled = false;

    }
    void Update()
    {
        if( MenuActive == true )
        {
            ConfirmPurchase.enabled = true;
            ConfirmPurchase.GetComponentInChildren<Text>().text = "Are you sure you want to buy " + MusicSelected + "? There are no refunds.";
        }

        else
        {
            ConfirmPurchase.enabled = false;
        }
    }

    public void BackButtonPress()
    {
        Application.LoadLevel( "Marketplace" );
    }

    public void SoundOneSelected()
    {
        MusicSelected = "Music One";
        MenuActive = true;
    }
    public void SoundTwoSelected()
    {
        MusicSelected = "Music Two";
        MenuActive = true;
    }
    public void SoundThreeSelected()
    {
        MusicSelected = "Music Three";
        MenuActive = true;
    }
    public void SoundFourSelected()
    {
        MusicSelected = "Music Four";
        MenuActive = true;
    }

    public void PurchaseAccept()
    {
        MenuActive = false;
    }
    public void PurchaseCancelled()
    {
        MenuActive = false;
    }
}
