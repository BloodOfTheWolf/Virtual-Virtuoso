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

    // AG 12-Jan-2016
    // Stops the menu music and kills the background note particles. Returns true if objects are found and destroyed, and false if not.
    void RemoveFrontEndObjects()
    {
        var SongholderObj = GameObject.Find( "Songholder" );
        var DistantPfxObj = GameObject.Find( "P_UI_NotesBackground_Distant_01" );
        var NearPfxObj = GameObject.Find( "P_UI_NotesBackground_Near_01" );

        // Menu music
        Destroy( SongholderObj );
        SongholderScript.IsCreated = false;

        // Background note particles (distant)
        DistantPfxObj.GetComponent<ParticleSystem>().Stop();
        Destroy( DistantPfxObj );

        // Background note particles (near)
        NearPfxObj.GetComponent<ParticleSystem>().Stop();
        Destroy( NearPfxObj );
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
