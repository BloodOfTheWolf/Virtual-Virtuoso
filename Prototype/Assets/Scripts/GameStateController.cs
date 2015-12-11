using UnityEngine;
using System.Collections;

public class GameStateController : MonoBehaviour
{
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

    //create new enumeration for each game state (screen)
    public enum GameState
    {
        MainMenu,
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

    public void ChangeState( GameState newState )
    {
        currentState = newState;
        switch( currentState )
        {
        case GameState.MainMenu:
            Application.LoadLevel( "MainMenu" );
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
            Destroy( GameObject.Find( "Songholder" ) ); // stops the menu music
            SongholderScript.IsCreated = false;
            break;
        case GameState.HotCrossBuns:
            Application.LoadLevel( "HotCrossBuns" );
            Destroy( GameObject.Find( "Songholder" ) );
            SongholderScript.IsCreated = false;
            break;
        case GameState.MaryLamb:
            Application.LoadLevel( "MaryLamb" );
            Destroy( GameObject.Find( "Songholder" ) );
            SongholderScript.IsCreated = false;
            break;
        case GameState.FurElise:
            Application.LoadLevel( "FurElise" );
            Destroy( GameObject.Find( "Songholder" ) );
            SongholderScript.IsCreated = false;
            break;
        case GameState.CanonInD:
            Application.LoadLevel( "CanonInD" );
            Destroy( GameObject.Find( "Songholder" ) );
            SongholderScript.IsCreated = false;
            break;
        case GameState.Entertainer:
            Application.LoadLevel( "TheEntertainer" );
            Destroy( GameObject.Find( "Songholder" ) );
            SongholderScript.IsCreated = false;
            
            break;
        }
    }
}
