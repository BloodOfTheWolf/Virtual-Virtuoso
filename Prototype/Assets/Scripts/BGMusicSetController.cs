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

    public Button[] MusicSetButtons;

    MarketplaceButtonHelper[] MusicSetScripts;
    bool[] MusicSetsBought;
    int[] MusicSetPrices;
    string[] MusicSetShortNames;
    string[] MusicSetLongNames;
    string[] MusicSetSoundPaths;


    /// <summary>
    /// Reference to the current selected set's numeric index.
    /// </summary>
    int currentSelectedSet;

    string PurchaseMessage;

    bool MenuActive = false;

    public Canvas ConfirmPurchase;

    GameObject SFXController;

	public SongholderScript BackgroundMusic;
	public PlayerScoreInfoScript CurrentMoney;

    // Use this for initialization
    void Start()
    {
        // Store each MusicSetScript
        

       // print( "SetThreeBought state = " + SetThreeBought );
        if( SetOneBought == true )
        {
            MusicSetOneBtn.GetComponent<MarketplaceButtonHelper>().SetButtonState( MarketplaceButtonHelper.ButtonState.Purchased );
        }
        if( SetTwoBought == true )
        {
            MusicSetTwoBtn.GetComponent<MarketplaceButtonHelper>().SetButtonState( MarketplaceButtonHelper.ButtonState.Purchased );
        }
        if( SetThreeBought == true )
        {
            MusicSetThreeBtn.GetComponent<MarketplaceButtonHelper>().SetButtonState( MarketplaceButtonHelper.ButtonState.Purchased );
        }
        if(SetFourBought == true)
        {
            MusicSetFourBtn.GetComponent<MarketplaceButtonHelper>().SetButtonState( MarketplaceButtonHelper.ButtonState.Purchased );
        }
        //MusicSetOneBtn.GetComponentInChildren<Text>().text = "MusicSetOne";
        //MusicSetTwoBtn.GetComponentInChildren<Text>().text = "MusicSetTwo";
        //MusicSetThreeBtn.GetComponentInChildren<Text>().text = "MusicSetThree";
        //MusicSetFourBtn.GetComponentInChildren<Text>().text = "MusicSetFour";
        //BackButton.GetComponentInChildren<Text>().text = "Back";      // See my comment in variable init area     -- AG 18-Feb-16
        ConfirmPurchase.enabled = false;
    }

    void Update()
    {
        SFXController = GameObject.Find( "SFXController" );
    }

	public void BeginPurchase()
	{
		if (CheckTransaction( 200)) 
		{
			ConfirmPurchase.enabled = true;
			ConfirmPurchase.GetComponentInChildren<Text>().text = "Are you sure you want to buy this song? There are no refunds.";
			
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

    public void MusicSetSelected(int selectedSet)
    {
        SFXController.GetComponent<SFXControllerScript>().ButtonPressed();

        // Update the currently selected set
        currentSelectedSet = selectedSet;
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

		// = GetComponent<AudioSource>(MusicSelected);
		//SongholderScript.BGSong.Play();

        switch( currentSelectedSet )
        {
        case 0:
            MusicSetOneBtn.GetComponent<MarketplaceButtonHelper>().SetButtonState( MarketplaceButtonHelper.ButtonState.Purchased );
            SetOneBought = true;
            if( Resources.Load<AudioClip>( "Songs/mus_etude_32khz" ) != null )
            {
                SongholderScript.BGSong.clip = Resources.Load<AudioClip>( "Songs/mus_etude_32khz" );
                SongholderScript.BGSong.Play();
                break;
            }
            else
            {
                Debug.Break();
            }

            break;
        case 1:
            MusicSetTwoBtn.GetComponent<MarketplaceButtonHelper>().SetButtonState( MarketplaceButtonHelper.ButtonState.Purchased );
            SetTwoBought = true;
            if( Resources.Load<AudioClip>( "Songs/mus_sonata_32khz" ) != null )
            {
                SongholderScript.BGSong.clip = Resources.Load<AudioClip>( "Songs/mus_sonata_32khz" );
                SongholderScript.BGSong.Play();
                break;
            }
            else
            {
                Debug.Break();
            }
            break;
        case 2:
            MusicSetThreeBtn.GetComponent<MarketplaceButtonHelper>().SetButtonState( MarketplaceButtonHelper.ButtonState.Purchased );
            SetThreeBought = true;
            if( Resources.Load<AudioClip>( "Songs/mus_jesu_32khz" ) != null )
            {
                SongholderScript.BGSong.clip = Resources.Load<AudioClip>( "Songs/mus_jesu_32khz" );
                SongholderScript.BGSong.Play();
                break;
            }
            else
            {
                Debug.Break();
            }
            break;
        case 3:
            MusicSetFourBtn.GetComponent<MarketplaceButtonHelper>().SetButtonState( MarketplaceButtonHelper.ButtonState.Purchased );
            SetFourBought = true;
            if( Resources.Load<AudioClip>( "Songs/mus_rondo_32khz" ) != null )
            {
                SongholderScript.BGSong.clip = Resources.Load<AudioClip>( "Songs/mus_rondo_32khz" );
                SongholderScript.BGSong.Play();
                break;
            }
            else
            {
                Debug.Break();
            }
            break;
        }
    }
    public void PurchaseCancelled()
    {
        SFXController.GetComponent<SFXControllerScript>().QuitButtonPressed();
		ConfirmPurchase.enabled = false;
        MenuActive = false;
    }

    /// <summary>
    /// Call this to verify whether or not the player has enough money to make the purchase.
    /// </summary>
    /// <param name="cost">The amount of money to compare with the player's funds.</param>
    /// <returns>True if the player has enough, false if the player doesn't have enough.</returns>
	public bool CheckTransaction(int cost)
	{
        if( PlayerScoreInfoScript.PlayerMoney >= 200 )
		{
			MenuActive = true;
			return true;
		}
		return false;
		//MenuActive = false;
	}
}
