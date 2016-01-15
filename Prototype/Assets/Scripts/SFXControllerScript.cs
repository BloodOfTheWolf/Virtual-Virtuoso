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

	// Use this for initialization
	void Awake () {

        SFXSource = GetComponent<AudioSource>();
        DontDestroyOnLoad( this.gameObject );

	}
	
	// Recieve functions from other scripts indicating which effect to play
	public void ButtonPressed () {

        SFXSource.PlayOneShot( ButtonPress, 1f );
	
	}

    public void ItemPurchased()
    {

        SFXSource.PlayOneShot( CashRegister, 1f );

    }

    public void SmlApplause()
    {

        SFXSource.PlayOneShot( SmallApplause, 1f );

    }

    public void MedApplause()
    {

        SFXSource.PlayOneShot( MediumApplause, 1f );

    }

    public void LrgApplause()
    {

        SFXSource.PlayOneShot( LargeApplause, 1f );

    }

    public void MsvApplause()
    {

        SFXSource.PlayOneShot( MassiveApplause, 1f );

    }

    public void CoinDrop()
    {

        SFXSource.PlayOneShot( MoneyGet, 1f );

    }

    public void MultiplierIncrease()
    {

        SFXSource.PlayOneShot( MultIncrease, 1f );

    }

    public void MultiplierFail()
    {

        SFXSource.PlayOneShot( MultReset, 1f );

    }

    public void ScoreInc()
    {

        SFXSource.PlayOneShot( ScoreTally, 1f );

    }

    public void StarRecieved()
    {

        SFXSource.PlayOneShot( StarGet, 1f );

    }

    public void NoteFail()
    {

        SFXSource.PlayOneShot( WrongNote, 1f );

    }

    public void SelectionButtonPressed()
    {

        SFXSource.PlayOneShot( OptionSwitch, 1f );

    }

    public void QuitButtonPressed()
    {

        SFXSource.PlayOneShot( QuitButton, 1f );

    }

    public void OptionAccepted()
    {

        SFXSource.PlayOneShot( StarGet, 1f );

    }
}
