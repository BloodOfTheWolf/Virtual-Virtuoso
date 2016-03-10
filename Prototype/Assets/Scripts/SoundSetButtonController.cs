using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SoundSetButtonController : MonoBehaviour
{

    //add public variable for each button we need in the song selection menu
    //public Button BackButton;     // AG 18-Feb-16
                                    //  We're handling all scene-transitioning buttons (to keep things clean and organized) 
                                    //  through ButtonHelper.cs, which then goes through UIEvents.cs and GameStateManager.cs
    public Button InstrumentSetOne;
    public Button InstrumentSetTwo;
    public Button InstrumentSetThree;
 

    //MarketplaceButtonHelper Market;
    public static bool InstrumentOneBought;
    public static bool InstrumentTwoBought;
    public static bool InstrumentThreeBought;
    public static bool InstrumentFourBought;

	public int price = 150;
    int CurrentInstrument;

    string SoundSelected;
    string PurchaseMessage;

    bool MenuActive = false;

    public Canvas ConfirmPurchase;

    GameObject SFXController;

    //NoteSoundManager NoteSoundScript;

	public PlayerScoreInfoScript Cash;

    // Use this for initialization
    void Start()
    {
        if( InstrumentOneBought == true )
        {
            InstrumentSetOne.GetComponent<MarketplaceButtonHelper>().SetButtonState( MarketplaceButtonHelper.ButtonState.Purchased );
        }
        if( InstrumentTwoBought == true )
        {
            InstrumentSetTwo.GetComponent<MarketplaceButtonHelper>().SetButtonState( MarketplaceButtonHelper.ButtonState.Purchased );
        }
        if( InstrumentThreeBought == true )
        {
            InstrumentSetThree.GetComponent<MarketplaceButtonHelper>().SetButtonState( MarketplaceButtonHelper.ButtonState.Purchased );
        }
      

        //SoundSetOne.GetComponentInChildren<Text>().text = "SoundSetOne";
        //SoundSetTwo.GetComponentInChildren<Text>().text = "SoundSetTwo";
        //SoundSetThree.GetComponentInChildren<Text>().text = "SoundSetThree";
        //SoundSetFour.GetComponentInChildren<Text>().text = "SoundSetFour";
        //SoundSetFive.GetComponentInChildren<Text>().text = "SoundSetFive";
        //BackButton.GetComponentInChildren<Text>().text = "Back";  // See my comment in variable init area     -- AG 18-Feb-16
        //SoundSelected = "";
        //ConfirmPurchase.enabled = false;

        SFXController = GameObject.Find( "SFXController" );
        //NoteSoundScript = SFXController.GetComponent<NoteSoundManager>();

    }

    void Update()
    {
        SFXController = GameObject.Find( "SFXController" );
		
    }

	public void BeginPurchase()
	{
		if (CheckTransaction(200))
		{
			
			ConfirmPurchase.enabled = true;
			ConfirmPurchase.GetComponentInChildren<Text> ().text = "Are you sure you want to buy this instrument? There are no refunds.";
			
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

    // TODO: Update the name for each sound!
    //public void SoundOneSelected()
    //{
    //    SFXController.GetComponent<SFXControllerScript>().ButtonPressed();
    //    SoundSelected = "Sound One";
    //    Purchase ();
    //}
    //public void SoundTwoSelected()
    //{
    //    SFXController.GetComponent<SFXControllerScript>().ButtonPressed();
    //    SoundSelected = "Sound Two";
    //    Purchase ();
    //}
    //public void SoundThreeSelected()
    //{
    //    SFXController.GetComponent<SFXControllerScript>().ButtonPressed();
    //    SoundSelected = "Sound Three";
    //    Purchase ();
    //}
    //public void SoundFourSelected()
    //{
    //    SFXController.GetComponent<SFXControllerScript>().ButtonPressed();
    //    SoundSelected = "Sound Four";
    //    Purchase ();
    //}
    //public void SoundFiveSelected()
    //{
    //    SFXController.GetComponent<SFXControllerScript>().ButtonPressed();
    //    SoundSelected = "Sound Five";
    //    Purchase ();
    //}

    public void InstrumentSelected( int selectedSet )
    {
        SFXController.GetComponent<SFXControllerScript>().ButtonPressed();

        // Update the currently selected set
        CurrentInstrument = selectedSet;
        print( "Cureent selected = " + selectedSet );
        // Begin the transaction (of a lifetime)
        BeginPurchase();
    }

    public void PurchaseAccept()
    {
		PlayerScoreInfoScript.PlayerMoney = PlayerScoreInfoScript.PlayerMoney - 200;
		print (" You have : " + PlayerScoreInfoScript.PlayerMoney);
        SFXController.GetComponent<SFXControllerScript>().ItemPurchased();
		ConfirmPurchase.enabled = false;
		MenuActive = false;

        switch( CurrentInstrument )
        {
        case 0:
        InstrumentSetOne.GetComponent<MarketplaceButtonHelper>().SetButtonState( MarketplaceButtonHelper.ButtonState.NotAvailable );
        InstrumentOneBought = true;
       
        break;
        case 1:
        InstrumentSetTwo.GetComponent<MarketplaceButtonHelper>().SetButtonState( MarketplaceButtonHelper.ButtonState.Purchased );
        //InstrumentSetTwo.GetComponent<MarketplaceButtonHelper>().SetButtonState( MarketplaceButtonHelper.ButtonState.NotAvailable );
        InstrumentTwoBought = true;
        break;

        case 2:
        InstrumentSetThree.GetComponent<MarketplaceButtonHelper>().SetButtonState( MarketplaceButtonHelper.ButtonState.Purchased );
        InstrumentThreeBought = true;

        break;
        }
        //case 3:
        //MusicSetFourBtn.GetComponent<MarketplaceButtonHelper>().SetButtonState( MarketplaceButtonHelper.ButtonState.Purchased );
        //SetFourBought = true;
        //if( Resources.Load<AudioClip>( "Songs/mus_rondo_32khz" ) != null )
        //{
        //    SongholderScript.BGSong.clip = Resources.Load<AudioClip>( "Songs/mus_rondo_32khz" );
        //    SongholderScript.BGSong.Play();
        //    break;
        //}
        //else
        //{
        //    Debug.Break();
        //}
        //break;
        //}
    }

    public void PurchaseCancelled()
    {
        SFXController.GetComponent<SFXControllerScript>().QuitButtonPressed();
		ConfirmPurchase.enabled = false;
		MenuActive = false;
    }

	public bool CheckTransaction(int price)
	{
		if (PlayerScoreInfoScript.PlayerMoney >= 200) 
		{
			MenuActive = true;
			return true;
			
		}
		return false;
		//MenuActive = false;
	}
}

