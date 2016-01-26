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

	public int price = 150;

    string MusicSelected;
    string PurchaseMessage;

    bool MenuActive = false;

    public Canvas ConfirmPurchase;

    GameObject SFXController;

	public SongholderScript BackgroundMusic;
	public PlayerScoreInfoScript CurrentMoney;

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
        SFXController = GameObject.Find( "SFXController" );
		
    }

	public void Purchase()
	{
		if (CheckTransaction (150)) 
		{
			
			ConfirmPurchase.enabled = true;
			ConfirmPurchase.GetComponentInChildren<Text> ().text = "Are you sure you want to buy " + MusicSelected + "? There are no refunds.";
			
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
        MusicSelected = "Music One";
		Purchase ();
    }
    public void SoundTwoSelected()
    {
        SFXController.GetComponent<SFXControllerScript>().ButtonPressed();
        MusicSelected = "Music Two";
		Purchase ();
    }
    public void SoundThreeSelected()
    {
        SFXController.GetComponent<SFXControllerScript>().ButtonPressed();
        MusicSelected = "Music Three";
		Purchase ();
    }
    public void SoundFourSelected()
    {
        SFXController.GetComponent<SFXControllerScript>().ButtonPressed();
        MusicSelected = "Music Four";
		Purchase ();
    }

    public void PurchaseAccept()
    {
		PlayerScoreInfoScript.PlayerMoney = PlayerScoreInfoScript.PlayerMoney - price;
		print (" You have : " + PlayerScoreInfoScript.PlayerMoney);
        SFXController.GetComponent<SFXControllerScript>().ItemPurchased();
		ConfirmPurchase.enabled = false;
        MenuActive = false;

		// = GetComponent<AudioSource> (MusicSelected);
		//SongholderScript.BGSong.Play ();
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
