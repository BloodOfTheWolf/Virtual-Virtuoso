using UnityEngine;
using System.Collections;
using UnityEngine.UI;


[RequireComponent(typeof(AudioSource))]


public class SheetNoteScript : MonoBehaviour
{
    //multiplier graphics
    public Image fillOne;
    public Image fillTwo;
    public Image fillThree;
    public Image fillFour;
    public Image fillFive;
    public Image fillSix;
    public Image fillSeven;
    public Image fillEight;
    public Image fillNine;
    public Image fillTen;
    public Image fillEleven;
    public Image fillTwelve;

	static SheetNoteScript Instance = null;

    /// Holder for the note's sound effect.
	AudioSource sheetaudio;

    /// 'Hit' icon.
	public GameObject GreenCheck;

    /// 'Missed' icon.
	public GameObject RedCheck;

    /// The player's score.
	public static int Score;

    /// The notestreak value.
	public static int NoteStreak;

    /// The player's highest streak obtained.
	public static int HighestStreak;

    /// The multiplier's base value.
	public static int Multiplier = 10;

    /// The losestreak value.
	public static int LoseStreak;

    /// The total number of notes the player played successfully. Primarily used for the results screen.
	public static int Hit;

    /// The total number of notes the player missed. Primarily used for the results screen.
	public static int Miss;

    /// The total number of notes in the song.  Primarily used for the results screen.
	public static float Total;

    /// The player's camera. Used for GUI purposes.
	Camera cam;

    /// The screen's height and width. Used for GUI purposes.
	float height, width;

    /// Bool determining whether or not this note should be colored.
    private bool Colored;

    /// The tutorial object.
    private GameObject Tutorial;

    /// The ParticleSystem to spawn when the player plays a note.
    public GameObject HitEffect;

    /// The ParticleSystem to spawn when the player misses a note.
    public GameObject MissEffect;


    /// The ParticleSystem to spawn when the Notestreak multiplier increases.
    public GameObject NotestreakMultiplierIncreaseEffect;

    /// The Vector3 position of the notestreak multiplier UI object.
    Vector3 NotestreakMultiplierEffectPosition;

    /// Stores the Vector3 location of the note's center.
    Vector3 HitLocation;

    /// Our audio controller object.
    GameObject SFXController;

    /// <summary>
    /// Our save data manager.
    /// </summary>
    GameObject SaveDataManagerObj;

    /// <summary>
    /// The save data manager's main script.
    /// </summary>
    SaveDataScript SaveDataManagerScript;

    public GameObject Perfect;

	public static SheetNoteScript GetInstance()
	{
		if (Instance == null) 
		{
			Instance = new SheetNoteScript();

		}
		return Instance;
	}

	// Use this for initialization
	void Start() 
	{
		sheetaudio = GetComponent<AudioSource>();
        GreenCheck = GameObject.Find( "greencheck" );
        RedCheck = GameObject.Find( "RedCheck" );
		Score = 0;
		NoteStreak = 0;
		HighestStreak = 0;
		LoseStreak = 0;
		Hit = 0;
		Miss = 0;
		Total = 0.0f;
		cam = Camera.main;
		height = 2f * cam.orthographicSize;
		width = height * cam.aspect;
        Colored = ColorToggleScript.Toggle;
       
        Perfect = GameObject.Find( "perfect_note_hit" );

        fillOne = GameObject.Find( "Fill1" ).GetComponentInChildren<Image>();
        fillTwo = GameObject.Find( "Fill2" ).GetComponentInChildren<Image>();
        fillThree = GameObject.Find( "Fill3" ).GetComponentInChildren<Image>();
        fillFour = GameObject.Find( "Fill4" ).GetComponentInChildren<Image>();
        fillFive = GameObject.Find( "Fill5" ).GetComponentInChildren<Image>();
        fillSix = GameObject.Find( "Fill6" ).GetComponentInChildren<Image>();
        fillSeven = GameObject.Find( "Fill7" ).GetComponentInChildren<Image>();
        fillEight = GameObject.Find( "Fill8" ).GetComponentInChildren<Image>();
        fillNine = GameObject.Find( "Fill9" ).GetComponentInChildren<Image>();
        fillTen = GameObject.Find( "Fill10" ).GetComponentInChildren<Image>();
        fillEleven = GameObject.Find( "Fill11" ).GetComponentInChildren<Image>();
        fillTwelve = GameObject.Find( "Fill12" ).GetComponentInChildren<Image>();

        fillOne.enabled = false;
        fillTwo.enabled = false;
        fillThree.enabled = false;
        fillFour.enabled = false;
        fillFive.enabled = false;
        fillSix.enabled = false;
        fillSeven.enabled = false;
        fillEight.enabled = false;
        fillNine.enabled = false;
        fillTen.enabled = false;
        fillEleven.enabled = false;
        fillTwelve.enabled = false;

        Tutorial = gameObject.transform.GetChild(0).GetChild(0).gameObject;
        if( Colored == false )
        {
            Tutorial.SetActive( false );

        }

        // AG 07-Jan-16
        // Get the center of the sprite and set the particle effect's spawn location
        var SpriteCenter = gameObject.GetComponentInChildren<SpriteRenderer>().bounds.extents.x;
        HitLocation = gameObject.transform.position - new Vector3( SpriteCenter, 0f, 0f );

        // Find and assign the save data manager object and script
        SaveDataManagerObj = GameObject.Find( "SaveData" );
        SaveDataManagerScript = SaveDataManagerObj.GetComponent<SaveDataScript>();
	}

	// Need to get the SFX Controller object
	void Update() 
	{
        SFXController = GameObject.Find( "SFXController" );
	}

	void OnTriggerEnter(Collider other)
	{
        
		if ((this.tag == "SheetNote" && other.tag == "BarNote") || (this.tag == "SharpSheetNote" && other.tag == "SharpBarNote") ) 
		{
            print( "sheetnotescrip sheetnote pos" + this.gameObject.transform.position.y );
            print( "sheetnotescrip barnote pos" + other.gameObject.transform.position.y );
            // Show the 'hit' icon
			GreenCheck.SetActive(true);
			//this.gameObject.SetActive(false);
            //Perfect.SetActive( true );
			RedCheck.SetActive(false);
            


            // Update the score
			Score += Multiplier;

            // Increment the note stats
			Hit++;
			Total++;

            // AG 19-Jan-16
            // Moved the Notestreak code into its own function for the sake of brevity and organization
            NotestreakMultiplierIncrement();
			
			//sheetaudio.Play();
			//Debug.Break();

            // AG 07-Jan-16
            // Play our hit effect at the note's location
            PlayParticleEffect( HitEffect, gameObject.transform.position );
		}
	}

    // AG 07-Jan-16
    /// Plays the specified ParticleSystem prefab 'pfx' at the specified Vector3 location 'spawnLocation'.
    /// <param name="pfx">Particle effect to spawn</param>
    /// <param name="spawnLocation">Location in which to spawn</param>
    /// 
    void PlayParticleEffect(GameObject pfx, Vector3 spawnLocation)
    {
        Instantiate( pfx, spawnLocation, Quaternion.identity );
    }

    // AG 19-Jan-16
    /// <summary>
    /// Increments the Notestreak multiplier.
    /// </summary>
    void NotestreakMultiplierIncrement()
    {
        // Increment the notestreak value
        NoteStreak++;

        // Update the highest streak if appropriate
        if( NoteStreak >= HighestStreak )
        {
            HighestStreak = NoteStreak;
            print( "Highest streak =" + HighestStreak );
        }

        // Print the values to the log
        print( "NoteStreak: " + NoteStreak );

        // Reset the losestreak
        LoseStreak = 0;


        // *********************
        // MULTIPLIER START

        // TODO: Fix NotestreakMultiplierEffectPosition's value.
        // Set the position of the 'notestreak multiplier increment' particle effect
        NotestreakMultiplierEffectPosition = new Vector3( 0, 0, 0 );
        print( NotestreakMultiplierEffectPosition.ToString() );
        print( gameObject.transform.position.ToString() );

        if( NoteStreak == 1 )
        {
            fillOne.enabled = true;
        }

        if( NoteStreak == 2 )
        {
            fillTwo.enabled = true;
        }

        // x2 Multiplier
        if( NoteStreak == 3 )
        {
            fillThree.enabled = true;

            // Play the 'multiplier increase' sound ditty
            SFXController.GetComponent<SFXControllerScript>().MultiplierIncrease();

            // Spawn the 'notestreak multiplier increment' particle effect
            PlayParticleEffect( NotestreakMultiplierIncreaseEffect, NotestreakMultiplierEffectPosition );

            // Double the multiplier value
            Multiplier *= 2;
        }

        if( NoteStreak == 4 )
        {
            fillFour.enabled = true;
        }

        if( NoteStreak == 5 )
        {
            fillFive.enabled = true;
        }

        //these are the additional multipliers, we need these later (and the math needs to be reworked to do 10 x2, x3, and x4)
        // AG 19-Jan-16:    It might be better to have the base Multiplier value set to 1, and then somewhere like in the update function have it multiplied by another 
        //                  variable, like MultiplierFactor, which would be set to 10.
        // x3 Multiplier(?)
        if( NoteStreak == 6 )
        {
            fillSix.enabled = true;

            // Play the 'multiplier increase' sound ditty
            SFXController.GetComponent<SFXControllerScript>().MultiplierIncrease();

            // Spawn the 'notestreak multiplier increment' particle effect
            PlayParticleEffect( NotestreakMultiplierIncreaseEffect, NotestreakMultiplierEffectPosition );

            // Double the multiplier value
            Multiplier *= 2;
        }

        if( NoteStreak == 7 )
        {
            fillSeven.enabled = true;
        }

        if( NoteStreak == 8 )
        {
            fillEight.enabled = true;
        }

        // x4 Multiplier(?)
        if( NoteStreak == 9 )
        {
            fillNine.enabled = true;

            // Play the 'multiplier increase' sound ditty
            SFXController.GetComponent<SFXControllerScript>().MultiplierIncrease();

            // Spawn the 'notestreak multiplier increment' particle effect
            PlayParticleEffect( NotestreakMultiplierIncreaseEffect, NotestreakMultiplierEffectPosition );

            // Double the multiplier value
            Multiplier *= 2;
        }

        if( NoteStreak == 10 )
        {
            fillTen.enabled = true;
        }

        if( NoteStreak == 11 )
        {
            fillEleven.enabled = true;
        }

        if( NoteStreak == 12 )
        {
            fillTwelve.enabled = true;
        }

        if (NoteStreak == 0)
        {
            fillTwelve.enabled = false;
            fillEleven.enabled = false;
            fillTen.enabled = false;
            fillNine.enabled = false;
            fillEight.enabled = false;
            fillSeven.enabled = false;
            fillSix.enabled = false;
            fillFive.enabled = false;
            fillFour.enabled = false;
            fillThree.enabled = false;
            fillTwo.enabled = false;
            fillOne.enabled = false;

            SFXController.GetComponent<SFXControllerScript>().MultiplierFail();
            Multiplier = 0;
        }

        // MULTIPLIER END
        // *********************
    }

	void OnTriggerExit(Collider other)
	{
        
		if (GreenCheck.activeInHierarchy || !(GreenCheck.activeInHierarchy)) // if you miss
		{
            // Play the 'failed' sound ditty
            SFXController.GetComponent<SFXControllerScript>().NoteFail();

            // Show the 'missed' icon
			RedCheck.SetActive(true);
			GreenCheck.SetActive(false);

			print("trigger exit called");

            // Reset the notestreak
			NoteStreak = 0;
			Multiplier = 10;

            // Increment the losestreaks
			LoseStreak += 1;

            // Increment the note stats
			Miss++;
			Total++;

            // If the player is doing just absolutely *terrible*, then...
			if(LoseStreak == 15)
			{
				//Application.isPlaying = false;
			}
		}

        // Don't show the 'hit' or 'failed' icon
		//GreenCheck.SetActive(false);
		//RedCheck.SetActive(false);
	}

    // HUD work
	void OnGUI()
	{
        // Initialize the GUI constructor
		GUIStyle style = new GUIStyle();

        // Set the font size
		style.fontSize = 30;

        // Draw the temporary text for the score and notestreak
		GUI.Label( new Rect( (Screen.width/2 + 200), (height + 10), 100, 100 ), "Score: " + Score.ToString(), style );
		GUI.Label( new Rect( (Screen.width/2 - 200), (height + 10), 100, 100 ), "NoteStreak: " + NoteStreak.ToString(), style );
	}

    /// <summary>
    /// Plays the note's sound effect.
    /// </summary>
	public void PlayNote()
	{
		sheetaudio.Play();
	}

    internal void NotestreakMultiplierIncreaseEffect()
    {
        throw new System.NotImplementedException();
    }
}
