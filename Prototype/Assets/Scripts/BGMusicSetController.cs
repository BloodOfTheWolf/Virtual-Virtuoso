using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BGMusicSetController : MonoBehaviour
{

    //add public variable for each button we need in the song selection menu
    //public Button BackButton;     // AG 18-Feb-16
                                    //  We're handling all scene-transitioning buttons (to keep things clean and organized) 
                                    //  through ButtonHelper.cs, which then goes through UIEvents.cs and GameStateManager.cs
    public Button MusicSetOneBtn;
    public Button MusicSetTwoBtn;
    public Button MusicSetThreeBtn;
    public Button MusicSetFourBtn;

    public static bool SetOneBought;
    public static bool SetTwoBought;
    public static bool SetThreeBought;
    public static bool SetFourBought;


    enum PurchaseChoice
    {
        MusicSetOne,
        MusicSetTwo,
        MusicSetThree,
        MusicSetFour
    };

    PurchaseChoice currentSelectedChoice;


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
        print( "SetThreeBought state = " + SetThreeBought );
        if(SetThreeBought == true)
        {
            MusicSetThreeBtn.GetComponent<MarketplaceButtonHelper>().SetButtonState( MarketplaceButtonHelper.ButtonState.Purchased );
        }
        MusicSetOneBtn.GetComponentInChildren<Text>().text = "MusicSetOne";
        MusicSetTwoBtn.GetComponentInChildren<Text>().text = "MusicSetTwo";
        MusicSetThreeBtn.GetComponentInChildren<Text>().text = "MusicSetThree";
        MusicSetFourBtn.GetComponentInChildren<Text>().text = "MusicSetFour";
        //BackButton.GetComponentInChildren<Text>().text = "Back";      // See my comment in variable init area     -- AG 18-Feb-16
        MusicSelected = "";
        ConfirmPurchase.enabled = false;
    }

    void Update()
    {
        SFXController = GameObject.Find( "SFXController" );
    }

	public void Purchase()
	{
		if (CheckTransaction(150)) 
		{
			
			ConfirmPurchase.enabled = true;
			ConfirmPurchase.GetComponentInChildren<Text>().text = "Are you sure you want to buy " + MusicSelected + "? There are no refunds.";
			
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
		Purchase();

        currentSelectedChoice = PurchaseChoice.MusicSetOne;
    }
    public void SoundTwoSelected()
    {
        SFXController.GetComponent<SFXControllerScript>().ButtonPressed();
        MusicSelected = "Music Two";
        Purchase();

        currentSelectedChoice = PurchaseChoice.MusicSetTwo;
    }
    public void SoundThreeSelected()
    {
        SFXController.GetComponent<SFXControllerScript>().ButtonPressed();
        MusicSelected = "Music Three";
        Purchase();

        currentSelectedChoice = PurchaseChoice.MusicSetThree;
    }
    public void SoundFourSelected()
    {
        SFXController.GetComponent<SFXControllerScript>().ButtonPressed();
        MusicSelected = "Music Four";
        Purchase();

        currentSelectedChoice = PurchaseChoice.MusicSetFour;
    }

    public void PurchaseAccept()
    {
		PlayerScoreInfoScript.PlayerMoney = PlayerScoreInfoScript.PlayerMoney - price;
		print (" You have : " + PlayerScoreInfoScript.PlayerMoney);
        SFXController.GetComponent<SFXControllerScript>().ItemPurchased();
		ConfirmPurchase.enabled = false;
        MenuActive = false;

		// = GetComponent<AudioSource>(MusicSelected);
		//SongholderScript.BGSong.Play();

        switch( currentSelectedChoice )
        {
        case PurchaseChoice.MusicSetOne:
            MusicSetOneBtn.GetComponent<MarketplaceButtonHelper>().SetButtonState( MarketplaceButtonHelper.ButtonState.Purchased );
            SetOneBought = true;

            break;
        case PurchaseChoice.MusicSetTwo:
            MusicSetTwoBtn.GetComponent<MarketplaceButtonHelper>().SetButtonState( MarketplaceButtonHelper.ButtonState.Purchased );
            SetTwoBought = true;
            break;
        case PurchaseChoice.MusicSetThree:
            MusicSetThreeBtn.GetComponent<MarketplaceButtonHelper>().SetButtonState( MarketplaceButtonHelper.ButtonState.Purchased );
            SetThreeBought = true;
            if( Resources.Load<AudioClip>( "Songs/mus_sonata_01" ) != null )
            {
                SongholderScript.BGSong.clip = Resources.Load<AudioClip>( "Songs/mus_sonata_01" );
                SongholderScript.BGSong.Play();
            }
            else
            {
                Debug.Break();
            }
            //BackgroundMusic.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>("mus_sonata_01");
            //BackgroundMusic.GetComponent<AudioSource>().Play();
            break;
        case PurchaseChoice.MusicSetFour:
            MusicSetFourBtn.GetComponent<MarketplaceButtonHelper>().SetButtonState( MarketplaceButtonHelper.ButtonState.Purchased );
            SetFourBought = true;
            break;
        }
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
