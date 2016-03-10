using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonHelper : MonoBehaviour
{
    GameObject UIEventsObj;
    BGMusicSetController BGMusicSetScript;
    Button myselfButton;

    public enum ButtonType
    {
        LoadSongSelection,
        LoadOptions,
        LoadMarketplace,
        LoadExit,
        SelectTutorial,
        SelectHotCrossBuns,
        SelectFurElise,
        SelectCanonInD,
        SelectEntertainer,
        LoadSelection,
        LoadMainMenu,
        LoadMainMenuFromResultsScreen,
        LoadSoundSetSelection,
        LoadBackgroundMusicSelection,
        ToggleNoteAssistMode,
        ToggleNoteColorMode,
        DebugUnlockAllSongs,
        MarketplaceConfirmPurchase,
        MarketplaceCancelPurchase,
        MusicSet,
        SoundSet
    };

    public ButtonType UIButton;

	void Start()
    {
        UIEventsObj = GameObject.Find( "UIEvents" );
        //BGMusicSetScript = GameObject.Find( "BGMusicController" ).GetComponent<BGMusicSetController>();

        myselfButton = GetComponent<Button>();
        myselfButton.onClick.AddListener( () => DoAction( UIButton ) );
	}

    void DoAction( ButtonType buttonToDo )
    {
        switch( buttonToDo )
        {
        case ButtonType.LoadSongSelection:
        print( "done" );
            UIEventsObj.GetComponent<UIEvents>().LoadSongSelection();
            break;
        case ButtonType.LoadOptions:
            Debug.Log( "ButtonHelper: Options" );
            break;
        case ButtonType.LoadMarketplace:
            UIEventsObj.GetComponent<UIEvents>().LoadMarketplace();
            break;
        case ButtonType.LoadExit:
            Debug.Log( "ButtonHelper: Exit" );
            break;
        case ButtonType.SelectTutorial:
            UIEventsObj.GetComponent<UIEvents>().SelectTutorial();
            break;
        case ButtonType.SelectHotCrossBuns:
            UIEventsObj.GetComponent<UIEvents>().SelectHotCrossBuns();
            break;
        case ButtonType.SelectFurElise:
            UIEventsObj.GetComponent<UIEvents>().SelectFurElise();
            break;
        case ButtonType.SelectCanonInD:
            UIEventsObj.GetComponent<UIEvents>().SelectCanonInD();
            break;
        case ButtonType.SelectEntertainer:
            UIEventsObj.GetComponent<UIEvents>().SelectEntertainer();
            break;
        case ButtonType.LoadSelection:
            UIEventsObj.GetComponent<UIEvents>().LoadSelection();
            break;
        case ButtonType.LoadMainMenu:
            UIEventsObj.GetComponent<UIEvents>().LoadMainMenu();
            break;
        case ButtonType.LoadMainMenuFromResultsScreen:
            UIEventsObj.GetComponent<UIEvents>().LoadMainMenuFromResultsScreen();
            break;
        case ButtonType.LoadSoundSetSelection:
            UIEventsObj.GetComponent<UIEvents>().LoadSoundSetSelection();
            break;
        case ButtonType.LoadBackgroundMusicSelection:
            UIEventsObj.GetComponent<UIEvents>().LoadBackgroundMusicSelection();
            //BGMusicSetScript.UpdateVars();
            break;
        case ButtonType.ToggleNoteAssistMode:
            UIEventsObj.GetComponent<UIEvents>().ToggleNoteAssistMode();
            break;
        case ButtonType.ToggleNoteColorMode:
            UIEventsObj.GetComponent<UIEvents>().ToggleNoteColorMode();
            break;
        case ButtonType.DebugUnlockAllSongs:
            UIEventsObj.GetComponent<UIEvents>().SongProgressionScript.UnlockDifficulty( SongProgressionManagerScript.DifficultyState.Hard );
            Debug.Log( "ButtonHelper.DoAction().DebugUnlockAllSongs: Unlocking all songs" );
            break;
        case ButtonType.MarketplaceConfirmPurchase:
            //BGMusicSetScript.AcceptPurchase();
            break;
        case ButtonType.MarketplaceCancelPurchase:
            //BGMusicSetScript.CancelPurchase();
            break;
        case ButtonType.MusicSet:
            BGMusicSetScript.MusicSetSelected( gameObject.GetComponent<MarketplaceButtonHelper>().SetIndex );
            break;
        case ButtonType.SoundSet:
            
            break;
        }
    }
}
