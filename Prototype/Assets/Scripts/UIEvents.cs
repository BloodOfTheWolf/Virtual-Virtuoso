using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIEvents : MonoBehaviour
{
    /// <summary>
    /// Is the timer running?
    /// </summary>
    bool bTimerActive = false;

    /// <summary>
    /// What's the timer's current value?
    /// </summary>
    public float LoadTimerValue = 0.5f;

    bool bLoadSelection = false;

    GameObject SFXController;

    public Transform objSongholder;
    public Canvas LoadscreenObject;

    public GameObject CurrencyCanvas;
    public PlayerCashTextScript CurrencyCanvasScript;

    public GameObject SongProgressionManagerObj;
    public SongProgressionManagerScript SongProgressionScript;

    public GameObject SaveDataObj;
    public SaveDataScript SaveDataScript;

    //create new enumeration for each song button
    public enum SongChoice
    {
        Tutorial,
        HotCrossBuns,
        MaryLamb,
        FurElise,
        CanonInD,
        Entertainer
    };

    SongChoice previousChoice;
    SongChoice currentChoice = SongChoice.Tutorial;

    //song selection handlers

    //***********************
    // EASY SONGS
    //***********************
    public void SelectTutorial()
    {
        // Has the player unlocked the song?
        if( SongProgressionScript.CurrentDifficultyUnlocked >= SongProgressionManagerScript.DifficultyState.Easy )
        {
            SFXController.GetComponent<SFXControllerScript>().SelectionButtonPressed();
            currentChoice = SongChoice.Tutorial;
            PlaySongPreview( currentChoice );
        }
        else
        {
            Debug.Log( "UIEvents.SelectTutorial(): Song not yet unlocked!" );

            //insert functionality here
        }
    }

    public void SelectHotCrossBuns()
    {
        // Has the player unlocked the song?
        if( SongProgressionScript.CurrentDifficultyUnlocked >= SongProgressionManagerScript.DifficultyState.Easy )
        {
            SFXController.GetComponent<SFXControllerScript>().SelectionButtonPressed();
            currentChoice = SongChoice.HotCrossBuns;
            PlaySongPreview( currentChoice );
        }
        else
        {
            Debug.Log( "UIEvents.SelectHotCrossBuns(): Song not yet unlocked!" );

            //insert functionality here
        }
    }

    public void SelectMaryLamb()
    {
        // Has the player unlocked the song?
        if( SongProgressionScript.CurrentDifficultyUnlocked >= SongProgressionManagerScript.DifficultyState.Easy )
        {
            SFXController.GetComponent<SFXControllerScript>().SelectionButtonPressed();
            currentChoice = SongChoice.MaryLamb;
            PlaySongPreview( currentChoice );
        }
        else
        {
            Debug.Log( "UIEvents.SelectMaryLamb(): Song not yet unlocked!" );

            //insert functionality here
        }
    }

    //***********************
    // MEDIUM SONGS
    //***********************
    public void SelectFurElise()
    {
        // Has the player unlocked the song?
        if( SongProgressionScript.CurrentDifficultyUnlocked >= SongProgressionManagerScript.DifficultyState.Medium )
        {
            SFXController.GetComponent<SFXControllerScript>().SelectionButtonPressed();
            currentChoice = SongChoice.FurElise;
            PlaySongPreview( currentChoice );
        }
        else
        {
            Debug.Log( "UIEvents.SelectFurElise(): Song not yet unlocked!" );

            //insert functionality here
        }
    }

    public void SelectCanonInD()
    {
        // Has the player unlocked the song?
        if( SongProgressionScript.CurrentDifficultyUnlocked >= SongProgressionManagerScript.DifficultyState.Medium )
        {
            SFXController.GetComponent<SFXControllerScript>().SelectionButtonPressed();
            currentChoice = SongChoice.CanonInD;
            PlaySongPreview( currentChoice );
        }
        else
        {
            Debug.Log( "UIEvents.SelectCanonInD(): Song not yet unlocked!" );

            //insert functionality here
        }
    }

    //***********************
    // HARD SONGS
    //***********************
    public void SelectEntertainer()
    {
        // Has the player unlocked the song?
        if( SongProgressionScript.CurrentDifficultyUnlocked >= SongProgressionManagerScript.DifficultyState.Hard )
        {
            SFXController.GetComponent<SFXControllerScript>().SelectionButtonPressed();
            currentChoice = SongChoice.Entertainer;
            PlaySongPreview( currentChoice );
        }
        else
        {
            Debug.Log( "UIEvents.SelectEntertainer(): Song not yet unlocked!" );

            //insert functionality here
        }
    }
    //end

    public void LoadSelection()
    {
        Debug.Log( "UIEvents.LoadSelection(): Entered" );
        LoadscreenObject.GetComponent<LoadManager>().PushScreen( 0.1f );
        bTimerActive = true;
        bLoadSelection = true;
    }

    void PlaySongPreview( SongChoice songPreview )
    {
        switch( songPreview )
        {
        case SongChoice.Tutorial:
            //insert functionality here
            
            break;
        case SongChoice.HotCrossBuns:
            //insert functionality here
            
            break;
        case SongChoice.MaryLamb:
            //insert functionality here
            
            break;
        case SongChoice.FurElise:
            //insert functionality here
            
            break;
        case SongChoice.CanonInD:
            //insert functionality here
            
            break;
        case SongChoice.Entertainer:
            //insert functionality here
            
            break;
        }
    }

    //keep object persistent
    void Start()
    {
        DontDestroyOnLoad( this.gameObject );

        SongProgressionManagerObj = GameObject.Find( "SongProgressionManager" );
        SongProgressionScript = SongProgressionManagerObj.GetComponent<SongProgressionManagerScript>();

        SaveDataObj = GameObject.Find( "SaveData" );
        SaveDataScript = SaveDataObj.GetComponent<SaveDataScript>();

        CurrencyCanvas = GameObject.Find( "CurrencyCanvas" );
        CurrencyCanvasScript = CurrencyCanvas.GetComponent<PlayerCashTextScript>();
    }

    //makes it so that the SFX Controller can be found in any scene
    void Update()
    {
        SFXController = GameObject.Find( "SFXController" );

        if( bTimerActive )
        {
            LoadTimerValue -= Time.deltaTime;
            
            if( ( bLoadSelection ) && (LoadTimerValue <= 0) )
            {
                Debug.Log( "UIEvents.Update(): Loading selection" );
                bTimerActive = false;

                switch( currentChoice )
                {
                case SongChoice.Tutorial:
                    LoadTutorial();
                    break;
                case SongChoice.HotCrossBuns:
                    LoadHotCrossBuns();
                    break;
                case SongChoice.MaryLamb:
                    LoadMaryLamb();
                    break;
                case SongChoice.FurElise:
                    LoadFurElise();
                    break;
                case SongChoice.CanonInD:
                    LoadCanonInD();
                    break;
                case SongChoice.Entertainer:
                    LoadEntertainer();
                    break;
                }
            }
        }
    }

    //screen loading handlers
    public void LoadMainMenu()
    {
        CurrencyCanvasScript.HideCash();
        SFXController.GetComponent<SFXControllerScript>().ButtonPressed();
        GameStateController.Instance.ChangeState( GameStateController.GameState.MainMenu );
    }

    public void LoadMainMenuFromResultsScreen()
    {
        CurrencyCanvasScript.HideCash();
        GameStateController.Instance.ChangeState( GameStateController.GameState.MainMenuPostResults );
    }

    public void LoadSongSelection()
    {
        CurrencyCanvasScript.HideCash();
        SFXController.GetComponent<SFXControllerScript>().ButtonPressed();
        GameStateController.Instance.ChangeState( GameStateController.GameState.SongSelection );
    }

    public void LoadMarketplace()
    {
        CurrencyCanvasScript.ShowCash();
        SFXController.GetComponent<SFXControllerScript>().ButtonPressed();
        GameStateController.Instance.ChangeState( GameStateController.GameState.Marketplace );
    }

    public void LoadSoundSetSelection()
    {
        CurrencyCanvasScript.ShowCash();
        SFXController.GetComponent<SFXControllerScript>().ButtonPressed();
        GameStateController.Instance.ChangeState( GameStateController.GameState.SoundSetSelection );
    }

    public void LoadBackgroundMusicSelection()
    {
        CurrencyCanvasScript.ShowCash();
        SFXController.GetComponent<SFXControllerScript>().ButtonPressed();
        GameStateController.Instance.ChangeState( GameStateController.GameState.BackgroundMusicSelection );
    }

    public void ToggleNoteAssistMode()
    {
        // Is Note Assist mode enabled?
        if( SaveDataScript.bNoteAssistModeEnabled )
        {
            SaveDataScript.bNoteAssistModeEnabled = false;
            Debug.Log( "UIEvents.ToggleNoteAssistMode(): Note Assist mode is now disabled" );
        }
        else
        {
            SaveDataScript.bNoteAssistModeEnabled = true;
            Debug.Log( "UIEvents.ToggleNoteAssistMode(): Note Assist mode is now enabled" );
        }
    }

    void LoadTutorial()
    {
        GameStateController.Instance.ChangeState( GameStateController.GameState.Tutorial );
    }

    void LoadHotCrossBuns()
    {
        GameStateController.Instance.ChangeState( GameStateController.GameState.HotCrossBuns );
    }

    void LoadMaryLamb()
    {
        GameStateController.Instance.ChangeState( GameStateController.GameState.MaryLamb );
    }

    void LoadFurElise()
    {
        GameStateController.Instance.ChangeState( GameStateController.GameState.FurElise );
    }

    void LoadCanonInD()
    {
        GameStateController.Instance.ChangeState( GameStateController.GameState.CanonInD );
    }

    void LoadEntertainer()
    {
        GameStateController.Instance.ChangeState( GameStateController.GameState.Entertainer );
    }
    //end
}
