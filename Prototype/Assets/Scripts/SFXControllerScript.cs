using UnityEngine;
using System.Collections;

public class SFXControllerScript : MonoBehaviour {
    
    private AudioSource SFXSource;
    public AudioClip ButtonPress;
    public AudioClip CashRegister;
    public AudioClip MassiveApplause;
    public AudioClip MediumApplause;
    public AudioClip MoneyGet;
    public AudioClip OptionSwitch;
    public AudioClip MultIncrease;
    public AudioClip ScoreTally;
    public AudioClip MultReset;
    public AudioClip SmallApplause;
    public AudioClip StarGet;
    public AudioClip LargeApplause;
    public AudioClip VolumeCtlEffect;
    public AudioClip WrongNote;
    public AudioClip QuitButton;

    private float SFXVol;

	// Use this for initialization
	void Awake () {

        SFXSource = GetComponent<AudioSource>();
        DontDestroyOnLoad( this.gameObject );
        SFXVol = SFXVolumeScript.SFXVolume;

	}
	
	// Recieve functions from other scripts indicating which effect to play
	public void ButtonPressed () {

        SFXSource.PlayOneShot( ButtonPress, 1.0f );
	
	}

    public void ItemPurchased()
    {

        SFXSource.PlayOneShot( CashRegister, 1.0f );

    }

    public void SmlApplause()
    {

        SFXSource.PlayOneShot( SmallApplause, 1.0f );

    }

    public void MedApplause()
    {

        SFXSource.PlayOneShot( MediumApplause, 1.0f );

    }

    public void LrgApplause()
    {

        SFXSource.PlayOneShot( LargeApplause, 1.0f );

    }

    public void MsvApplause()
    {

        SFXSource.PlayOneShot( MassiveApplause, 1.0f );

    }

    public void CoinDrop()
    {

        SFXSource.PlayOneShot( MoneyGet, 1.0f );

    }

    public void MultiplierIncrease()
    {

        SFXSource.PlayOneShot( MultIncrease, 1.0f );

    }

    public void MultiplierFail()
    {

        SFXSource.PlayOneShot( MultReset, 1.0f );

    }

    public void ScoreInc()
    {

        SFXSource.PlayOneShot( ScoreTally, 1.0f );

    }

    public void StarRecieved()
    {

        SFXSource.PlayOneShot( StarGet, 1.0f );

    }

    public void NoteFail()
    {

        SFXSource.PlayOneShot( WrongNote, 1.0f );

    }

    public void SelectionButtonPressed()
    {

        SFXSource.PlayOneShot( OptionSwitch, 1.0f );

    }

    public void QuitButtonPressed()
    {

        SFXSource.PlayOneShot( QuitButton, 1.0f );

    }

    public void OptionAccepted()
    {

        SFXSource.PlayOneShot( StarGet, 1.0f );

    }
}
