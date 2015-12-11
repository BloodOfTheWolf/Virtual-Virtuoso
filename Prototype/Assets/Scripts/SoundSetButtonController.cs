using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SoundSetButtonController : MonoBehaviour {

    //add public variable for each button we need in the song selection menu
    public Button BackButton;
    public Button SoundSetOne;
    public Button SoundSetTwo;
    public Button SoundSetThree;
    public Button SoundSetFour;
    public Button SoundSetFive;

    string SoundSelected;
    string PurchaseMessage;

    bool MenuActive = false;

    public Canvas ConfirmPurchase;

    // Use this for initialization
    void Start()
    {
        SoundSetOne.GetComponentInChildren<Text>().text = "SoundSetOne";
        SoundSetTwo.GetComponentInChildren<Text>().text = "SoundSetTwo";
        SoundSetThree.GetComponentInChildren<Text>().text = "SoundSetThree";
        SoundSetFour.GetComponentInChildren<Text>().text = "SoundSetFour";
        SoundSetFive.GetComponentInChildren<Text>().text = "SoundSetFive";
        BackButton.GetComponentInChildren<Text>().text = "Back";
        SoundSelected = "";
        ConfirmPurchase.enabled = false;

    }
    void Update()
    {
        if( MenuActive == true )
        {
            ConfirmPurchase.enabled = true;
            ConfirmPurchase.GetComponentInChildren<Text>().text = "Are you sure you want to buy " + SoundSelected + "? There are no refunds.";
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
        SoundSelected = "Sound One";
        MenuActive = true;
    }
    public void SoundTwoSelected()
    {
        SoundSelected = "Sound Two";
        MenuActive = true;
    }
    public void SoundThreeSelected()
    {
        SoundSelected = "Sound Three";
        MenuActive = true;
    }
    public void SoundFourSelected()
    {
        SoundSelected = "Sound Four";
        MenuActive = true;
    }
    public void SoundFiveSelected()
    {
        SoundSelected = "Sound Five";
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

