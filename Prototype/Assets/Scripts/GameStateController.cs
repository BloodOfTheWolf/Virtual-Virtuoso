using UnityEngine;
using System.Collections;

public class GameStateController : MonoBehaviour
{

    GameObject PFXControllerInst;

    private static GameStateController instance = null;
    public static GameStateController Instance
    {
        get
        {
            if( instance == null )
            {
                GameObject go = new GameObject( "GameStateController" );
                instance = go.AddComponent<GameStateController>();
                DontDestroyOnLoad( go );
            }
            return instance;
        }
    }

    void Start()
    {
        PFXControllerInst = GameObject.Find( "BackgroundPFX" );
    }

    //create new enumeration for each game state (screen)
    public enum GameState
    {
        MainMenu,
        MainMenuPostResults,
        Marketplace,
        SoundSetSelection,
        BackgroundMusicSelection,
        SongSelection,
        Tutorial,
        HotCrossBuns,
        MaryLamb,
        FurElise,
        CanonInD,
        Entertainer
    };

    GameState previousState;
    GameState currentState = GameState.SongSelection;

    public GameState getState()
    {
        return currentState;
    }

    public GameState getPreviousState()
    {
        return previousState;
    }

    public void setPreviousState( GameState oldState )
    {
        previousState = oldState;
    }

    // AG 12-Jan-2016
    // Stops the menu music and kills the background note particles. Returns true if objects are found and destroyed, and false if not.
    void RemoveFrontEndObjects()
    {
        Debug.Log( "GameStateController.RemoveFrontEndObjects(): Entered" );

        var SongholderObj = GameObject.Find( "Songholder" );

        // Menu music
        Destroy( SongholderObj );
        SongholderScript.IsCreated = false;

        PFXControllerInst.GetComponent<PFXController>().StopEffects();
    }

    public void ChangeState( GameState newState )
    {
        currentState = newState;
        switch( currentState )
        {
        case GameState.MainMenu:
            Application.LoadLevel( "MainMenu" );
            PFXControllerInst.GetComponent<PFXController>().PlayEffects();
            break;
        case GameState.MainMenuPostResults:
            Application.LoadLevel( "SongSelectionMenu" );
            PFXControllerInst.GetComponent<PFXController>().ForceSpawnObjects();
            break;
        case GameState.Marketplace:
            Application.LoadLevel( "Marketplace" );
            break;
        case GameState.SoundSetSelection:
            Application.LoadLevel( "SoundSetSelectionMenu" );
            break;
        case GameState.BackgroundMusicSelection:
            Application.LoadLevel( "BackgroundMusicSelectionMenu" );
            break;
        case GameState.SongSelection:
            Application.LoadLevel( "SongSelectionMenu" );
            break;
        case GameState.Tutorial:
            Application.LoadLevel( "Main" );
            RemoveFrontEndObjects();    // AG 12-Jan-2016 -- replaced old code with reusable function
            break;
        case GameState.HotCrossBuns:
            Application.LoadLevel( "HotCrossBuns" );
            RemoveFrontEndObjects();
            break;
        case GameState.MaryLamb:
            Application.LoadLevel( "MaryLamb" );
            RemoveFrontEndObjects();
            break;
        case GameState.FurElise:
            Application.LoadLevel( "FurElise" );
            RemoveFrontEndObjects();
            break;
        case GameState.CanonInD:
            Application.LoadLevel( "CanonInD" );
            RemoveFrontEndObjects();
            break;
        case GameState.Entertainer:
            Application.LoadLevel( "TheEntertainer" );
            RemoveFrontEndObjects();
            break;
        }
    }
}
