using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SongProgressionManagerScript : MonoBehaviour
{
    public bool bTutorialDone = false;
    public bool bHotCrossBunsDone = false;
    public bool bMaryLambDone = false;
    public bool bFurEliseDone = false;
    public bool bCanonInDDone = false;
    public bool bEntertainerDone = false;
    
    /// <summary>
    /// Constructor for our DifficultyState enumerator.
    /// </summary>
    public enum DifficultyState
    {
        Easy,
        Medium,
        Hard
    };

    /// <summary>
    /// The player's currently unlocked difficulty state.
    /// </summary>
    public DifficultyState CurrentDifficultyUnlocked;

    void Start()
    {
        DontDestroyOnLoad( this.gameObject );
        UnlockDifficulty( DifficultyState.Easy );
    }

    /// <summary>
    /// Updates the state of a given song depending on /songLevelName/.
    /// </summary>
    /// <param name="songLevelName">The name of the song's scene.</param>
    public void UpdateSongStates( string songLevelName )
    {
        Debug.Log( "SongProgressionManagerScript.UpdateSongStates(): songLevelName: " + songLevelName );

        switch( songLevelName )
        {
        case "Main":
            bTutorialDone = true;
            break;
        case "HotCrossBuns":
            bHotCrossBunsDone = true;
            break;
        case "MaryLamb":
            bMaryLambDone = true;
            break;
        case "FurElise":
            bFurEliseDone = true;
            break;
        case "CanonInD":
            bCanonInDDone = true;
            break;
        case "TheEntertainer":
            bEntertainerDone = true;
            break;
        }

        if( (bTutorialDone) && (bHotCrossBunsDone) && (bMaryLambDone) )
        {
            UnlockDifficulty( DifficultyState.Medium );
        }

        if( (bFurEliseDone) && (bCanonInDDone) )
        {
            UnlockDifficulty( DifficultyState.Hard );
        }
    }

    /// <summary>
    /// Updates the player's current difficulty state to /newDifficulty/.
    /// </summary>
    /// <param name="newDifficulty"></param>
    public void UnlockDifficulty( DifficultyState newDifficulty )
    {
        Debug.Log( "SongProgressionManagerScript.UnlockDifficulty(): Unlocked difficulty: " + newDifficulty.ToString() );
        CurrentDifficultyUnlocked = newDifficulty;
    }
}
