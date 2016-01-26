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

	public int price = 150;

    string SoundSelected;
    string PurchaseMessage;

    bool MenuActive = false;

    public Canvas ConfirmPurchase;

    GameObject SFXController;

	public PlayerScoreInfoScript Cash ;

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
        SFXController = GameObject.Find( "SFXController" );
		
    }

	public void Purchase()
	{
		if (CheckTransaction (150)) 
		{
			
			ConfirmPurchase.enabled = true;
			ConfirmPurchase.GetComponentInChildren<Text> ().text = "Are you sure you want to buy " + SoundSelected + "? There are no refunds.";
			
			//			else
			//			{
			//
			//				ConfirmPurchase.GetComponentInChildren<Text> ().text = "Sorry, You dont have enough funds.";
			//			}
		}
		
		else
		{
			ConfirmPurchase.enabled = false;
			
		}
	}

    public void BackButtonPress()
    {
        SFXController.GetComponent<SFXControllerScript>().QuitButtonPressed();
        Application.LoadLevel( "Marketplace" );
    }

    public void SoundOneSelected()
    {
        SFXController.GetComponent<SFXControllerScript>().ButtonPressed();
        SoundSelected = "Sound One";
		Purchase ();
    }
    public void SoundTwoSelected()
    {
        SFXController.GetComponent<SFXControllerScript>().ButtonPressed();
        SoundSelected = "Sound Two";
		Purchase ();
    }
    public void SoundThreeSelected()
    {
        SFXController.GetComponent<SFXControllerScript>().ButtonPressed();
        SoundSelected = "Sound Three";
		Purchase ();
    }
    public void SoundFourSelected()
    {
        SFXController.GetComponent<SFXControllerScript>().ButtonPressed();
        SoundSelected = "Sound Four";
		Purchase ();
    }
    public void SoundFiveSelected()
    {
        SFXController.GetComponent<SFXControllerScript>().ButtonPressed();
        SoundSelected = "Sound Five";
		Purchase ();
    }

    public void PurchaseAccept()
    {
		PlayerScoreInfoScript.PlayerMoney = PlayerScoreInfoScript.PlayerMoney - price;
		print (" You have : " + PlayerScoreInfoScript.PlayerMoney);
        SFXController.GetComponent<SFXControllerScript>().ItemPurchased();
		ConfirmPurchase.enabled = false;
		MenuActive = false;
    }
    public void PurchaseCancelled()
    {
        SFXController.GetComponent<SFXControllerScript>().QuitButtonPressed();
		ConfirmPurchase.enabled = false;
		MenuActive = false;
    }

	public bool CheckTransaction(int price)
	{
		if (PlayerScoreInfoScript.PlayerMoney > price) 
		{
			MenuActive = true;
			return true;
			
		}
		return false;
		//MenuActive = false;
	}
}

