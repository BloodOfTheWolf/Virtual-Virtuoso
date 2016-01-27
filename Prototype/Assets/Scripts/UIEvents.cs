using UnityEngine;
using System.Collections;

public class UIEvents : MonoBehaviour
{

    GameObject SFXController;

    public Transform objSongholder;

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
    public void SelectTutorial()
    {
        SFXController.GetComponent<SFXControllerScript>().SelectionButtonPressed();
        currentChoice = SongChoice.Tutorial;
        PlaySongPreview( currentChoice );
    }

    public void SelectHotCrossBuns()
    {
        SFXController.GetComponent<SFXControllerScript>().SelectionButtonPressed();
        currentChoice = SongChoice.HotCrossBuns;
        PlaySongPreview( currentChoice );
    }

    public void SelectMaryLamb()
    {
        SFXController.GetComponent<SFXControllerScript>().SelectionButtonPressed();
        currentChoice = SongChoice.MaryLamb;
        PlaySongPreview( currentChoice );
    }

    public void SelectFurElise()
    {
        SFXController.GetComponent<SFXControllerScript>().SelectionButtonPressed();
        currentChoice = SongChoice.FurElise;
        PlaySongPreview( currentChoice );
    }

    public void SelectCanonInD()
    {
        SFXController.GetComponent<SFXControllerScript>().SelectionButtonPressed();
        currentChoice = SongChoice.CanonInD;
        PlaySongPreview( currentChoice );
    }

    public void SelectEntertainer()
    {
        SFXController.GetComponent<SFXControllerScript>().SelectionButtonPressed();
        currentChoice = SongChoice.Entertainer;
        PlaySongPreview( currentChoice );
    }
    //end

    public void LoadSelection()
    {
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
    }

    //makes it so that the SFX Controller can be found in any scene
    void Update()
    {
        SFXController = GameObject.Find( "SFXController" );
    }

    //screen loading handlers
    public void LoadMainMenu()
    {
        SFXController.GetComponent<SFXControllerScript>().ButtonPressed();
        GameStateController.Instance.ChangeState( GameStateController.GameState.MainMenu );
    }

    public void LoadMainMenuFromResultsScreen()
    {
        GameStateController.Instance.ChangeState( GameStateController.GameState.MainMenuPostResults );
    }

    public void LoadSongSelection()
    {
        SFXController.GetComponent<SFXControllerScript>().ButtonPressed();
        GameStateController.Instance.ChangeState( GameStateController.GameState.SongSelection );
    }

    public void LoadMarketplace()
    {
        SFXController.GetComponent<SFXControllerScript>().ButtonPressed();
        GameStateController.Instance.ChangeState( GameStateController.GameState.Marketplace );
    }

    public void LoadSoundSetSelection()
    {
        SFXController.GetComponent<SFXControllerScript>().ButtonPressed();
        GameStateController.Instance.ChangeState( GameStateController.GameState.SoundSetSelection );
    }

    public void LoadBackgroundMusicSelection()
    {
        SFXController.GetComponent<SFXControllerScript>().ButtonPressed();
        GameStateController.Instance.ChangeState( GameStateController.GameState.BackgroundMusicSelection );
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
