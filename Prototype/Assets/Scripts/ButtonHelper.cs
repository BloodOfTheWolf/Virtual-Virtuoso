using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonHelper : MonoBehaviour
{
    GameObject UIEventsObj;
    Button myselfButton;

    public enum ButtonType
    {
        LoadSongSelection,
        LoadOptions,
        LoadMarketplace,
        LoadExit,
        SelectTutorial,
        SelectHotCrossBuns,
        SelectMaryLamb,
        SelectFurElise,
        SelectCanonInD,
        SelectEntertainer,
        LoadSelection,
        LoadMainMenu,
        LoadMainMenuFromResultsScreen,
        LoadSoundSetSelection,
        LoadBackgroundMusicSelection

    };

    public ButtonType UIButton;

	void Start()
    {
        UIEventsObj = GameObject.Find( "UIEvents" );

        myselfButton = GetComponent<Button>();
        myselfButton.onClick.AddListener( () => DoAction( UIButton ) );
	}

    void DoAction( ButtonType buttonToDo )
    {
        switch( buttonToDo )
        {
        case ButtonType.LoadSongSelection:
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
        case ButtonType.SelectMaryLamb:
            UIEventsObj.GetComponent<UIEvents>().SelectMaryLamb();
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
            break;
        }
    }
}
