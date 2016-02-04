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

    public static float SFXVol;

	// Use this for initialization
	void Awake () {

        SFXSource = GetComponent<AudioSource>();
        DontDestroyOnLoad( this.gameObject );
        if(SFXVolumeScript.SFXVolume == 0)
        {
            SFXVol = 0.5f;
        }
        else
        {
            SFXVol = SFXVolumeScript.SFXVolume;
        }

	}
	
	// Recieve functions from other scripts indicating which effect to play
	public void ButtonPressed () {

        SFXSource.PlayOneShot( ButtonPress, SFXVol );
	
	}

    public void ItemPurchased()
    {

        SFXSource.PlayOneShot( CashRegister, SFXVol );

    }

    public void SmlApplause()
    {

        SFXSource.PlayOneShot( SmallApplause, SFXVol );

    }

    public void MedApplause()
    {

        SFXSource.PlayOneShot( MediumApplause, SFXVol );

    }

    public void LrgApplause()
    {

        SFXSource.PlayOneShot( LargeApplause, SFXVol );

    }

    public void MsvApplause()
    {

        SFXSource.PlayOneShot( MassiveApplause, SFXVol );

    }

    public void CoinDrop()
    {

        SFXSource.PlayOneShot( MoneyGet, SFXVol );

    }

    public void MultiplierIncrease()
    {

        SFXSource.PlayOneShot( MultIncrease, SFXVol );

    }

    public void MultiplierFail()
    {

        SFXSource.PlayOneShot( MultReset, SFXVol );

    }

    public void ScoreInc()
    {

        SFXSource.PlayOneShot( ScoreTally, SFXVol );

    }

    public void StarRecieved()
    {

        SFXSource.PlayOneShot( StarGet, SFXVol );

    }

    public void NoteFail()
    {

        SFXSource.PlayOneShot( WrongNote, SFXVol );

    }

    public void SelectionButtonPressed()
    {

        SFXSource.PlayOneShot( OptionSwitch, SFXVol );

    }

    public void QuitButtonPressed()
    {

        SFXSource.PlayOneShot( QuitButton, SFXVol );

    }

    public void OptionAccepted()
    {

        SFXSource.PlayOneShot( StarGet, SFXVol );

    }
}
