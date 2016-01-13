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

	// Use this for initialization
	void Awake () {

        SFXSource = GetComponent<AudioSource>();
        DontDestroyOnLoad( this.gameObject );

	}
	
	// Update is called once per frame
	public void ButtonPressed () {

        SFXSource.PlayOneShot( ButtonPress, 1f );
	
	}
}
