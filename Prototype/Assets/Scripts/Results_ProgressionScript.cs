﻿using UnityEngine;
using System.Collections;

public class Results_ProgressionScript : MonoBehaviour 
{
    public int ResultsStep = 0;
    public AudioSource DrumRollSpawner;
    public AudioSource CrashSpawner;
    public AudioClip SmallCrash;
    public AudioClip BigCrash;
    public AudioClip DrumRoll;
    public float Countdown = 1.0f;
	
    void Awake ()
    {
        PlayDrumRoll();
    }

	// Update is called once per frame
	void Update () 
    {
        Countdown -= Time.deltaTime;
        //Debug.Log( "DrumRoll Playing: " + DrumRollSpawner.isPlaying.ToString() );

        //Allows the player to skip the tally
        /*if ((Input.GetMouseButtonDown(0)) && (ResultsStep < 6) && (Countdown <= 0.0f))
        {
            PlayCrash();
        }*/

        //As long as the timer is less than zero, run the drum roll function
        if ((Countdown <= 0.0f) && (DrumRollSpawner.isPlaying == false) && (ResultsStep < 5))
        {
            Debug.Log( "Running DrumRoll: " + ResultsStep.ToString() );
            PlayDrumRoll();
        }
	}

    void PlayDrumRoll()
    {
        DrumRollSpawner.loop = true;
        DrumRollSpawner.clip = DrumRoll;
        DrumRollSpawner.Play();
        ResultsStep += 1;
    }
    
    public void PlayCrash()
    {
        DrumRollSpawner.loop = false;
        DrumRollSpawner.Stop();
        if( ResultsStep < 5 )
        {
            CrashSpawner.PlayOneShot( SmallCrash );
        }
        else
        {
            CrashSpawner.PlayOneShot( BigCrash );
        }
        Countdown = 2.0f;
    }
}
