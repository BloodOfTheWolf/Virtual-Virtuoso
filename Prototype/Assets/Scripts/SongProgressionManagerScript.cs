﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class SongProgressionManagerScript : MonoBehaviour
{
    public bool bTutorialDone = false;
    public bool bHotCrossBunsDone = false;
    public bool bFurEliseDone = false;
    public bool bCanonInDDone = false;
    public bool bEntertainerDone = false;
    public Image EliseLock;
    public Image CanonLock;
    public Image EntertainLock;
    
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
    /// Call this to remind the parent object to update the lock image vars.
    /// </summary>
    //public void GetSongLockComponents()
    //{
    //    EliseLock = GameObject.Find( "EliseLock" ).GetComponent<Image>();
    //    CanonLock = GameObject.Find( "CanonLock" ).GetComponent<Image>();
    //    EntertainLock = GameObject.Find( "EntertainLock" ).GetComponent<Image>();
    //}


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

        if( (bTutorialDone) && (bHotCrossBunsDone) )
        {
            UnlockDifficulty( DifficultyState.Medium );
           // MediumUnlock();
        }

        if( (bFurEliseDone) && (bEntertainerDone) )
        {
            UnlockDifficulty( DifficultyState.Hard );
            //HardUnlock();
        }
    }


    //void MediumUnlock()
    //{
    //    EliseLock.enabled = false;
    //    CanonLock.enabled = false;
    //}


    //void HardUnlock()
    //{
    //    EntertainLock.enabled = false;
    //}


    /// <summary>
    /// Updates the player's current difficulty state to /newDifficulty/.
    /// </summary>
    /// <param name="newDifficulty"></param>
    public void UnlockDifficulty( DifficultyState newDifficulty )
    {
        Debug.Log( "SongProgressionManagerScript.UnlockDifficulty(): Unlocked difficulty: " + newDifficulty.ToString() );
        CurrentDifficultyUnlocked = newDifficulty;
        //MediumUnlock();
        //HardUnlock();
    }
}