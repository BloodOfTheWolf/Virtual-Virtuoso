using UnityEngine;
using System.Collections;

public class UIEvents : MonoBehaviour
{

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
        currentChoice = SongChoice.Tutorial;
        PlaySongPreview( currentChoice );
    }

    public void SelectHotCrossBuns()
    {
        currentChoice = SongChoice.HotCrossBuns;
        PlaySongPreview( currentChoice );
    }

    public void SelectMaryLamb()
    {
        currentChoice = SongChoice.MaryLamb;
        PlaySongPreview( currentChoice );
    }

    public void SelectFurElise()
    {
        currentChoice = SongChoice.FurElise;
        PlaySongPreview( currentChoice );
    }

    public void SelectCanonInD()
    {
        currentChoice = SongChoice.CanonInD;
        PlaySongPreview( currentChoice );
    }

    public void SelectEntertainer()
    {
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

    //screen loading handlers
    void LoadMainMenu()
    {
        GameStateController.Instance.ChangeState( GameStateController.GameState.MainMenu );
    }

    void LoadSongSelection()
    {
        GameStateController.Instance.ChangeState( GameStateController.GameState.SongSelection );
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
