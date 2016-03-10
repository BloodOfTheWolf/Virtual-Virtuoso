using UnityEngine;
using System.Collections;
using UnityEngine.UI;


[RequireComponent(typeof(AudioSource))]


public class SheetNoteScript : MonoBehaviour
{

	static SheetNoteScript Instance = null;

    /// Holder for the note's sound effect.
	AudioSource sheetaudio;
    ///// 'Hit' icon.
    //public GameObject GreenCheck;
    ///// 'Missed' icon.
    //public GameObject RedCheck;

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


    /// Stores the Vector3 location of the note's center.
    Vector3 HitLocation;

    /// Our notestreak controller script component.
    NoteStreakControllerScript NSController;

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


	void Start() 
	{
        NSController = GameObject.Find( "MultiplierCanvas" ).GetComponent<NoteStreakControllerScript>();

		sheetaudio = GetComponent<AudioSource>();
        //GreenCheck = GameObject.Find( "greencheck" );
        //RedCheck = GameObject.Find( "RedCheck" );
		cam = Camera.main;
		height = 2f * cam.orthographicSize;
		width = height * cam.aspect;
        if( ColorToggleScript.Toggle == false )
        {
            Colored = false;

        }
        else
        {
            Colored = ColorToggleScript.Toggle;
        }

        Perfect = GameObject.Find( "perfect_note_hit" );


        Tutorial = gameObject.transform.GetChild(0).GetChild(0).gameObject;
        if( Colored == false )
        {
            Tutorial.SetActive( false );
            //print( "Colored state " + Colored );
        }
        else
        {
            Tutorial.SetActive( true );
        }
        //Tutorial.SetActive( false );

        // AG 07-Jan-16
        // Get the center of the sprite and set the particle effect's spawn location
        var SpriteCenter = gameObject.GetComponentInChildren<SpriteRenderer>().bounds.extents.x;
        HitLocation = gameObject.transform.position - new Vector3( SpriteCenter, 0f, 0f );

        // Find and assign the save data manager object and script
        SaveDataManagerObj = GameObject.Find( "SaveData" );
        //SaveDataManagerScript = SaveDataManagerObj.GetComponent<SaveDataScript>();
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
            //print( "sheetnotescrip sheetnote pos" + this.gameObject.transform.position.y );
            //print( "sheetnotescrip barnote pos" + other.gameObject.transform.position.y );
            // Show the 'hit' icon
			//GreenCheck.SetActive(true);
			//this.gameObject.SetActive(false);
            //Perfect.SetActive( true );
			//RedCheck.SetActive(false);

            //NSController.HitNote();
			
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
    public void PlayParticleEffect(GameObject pfx, Vector3 spawnLocation)
    {
        Instantiate( pfx, spawnLocation, Quaternion.identity );
    }

    /// <summary>
    /// Call this to play this note's /HitEffect/ particle effect.
    /// </summary>
    public void HitNote()
    {
        PlayParticleEffect(HitEffect, gameObject.transform.position);
    }


    /// <summary>
    /// Call this to play this note's /MissEffect/ particle effect.
    /// </summary>
    public void MissNote()
    {
        PlayParticleEffect(MissEffect, gameObject.transform.position);
    }


	void OnTriggerExit(Collider other)
	{
        
        //if (GreenCheck.activeInHierarchy || !(GreenCheck.activeInHierarchy)) // if you miss
        //{
            // Play the 'failed' sound ditty
            //SFXController.GetComponent<SFXControllerScript>().NoteFail();

            // Show the 'missed' icon
            //RedCheck.SetActive(true);
            //GreenCheck.SetActive(false);

            //print("trigger exit called");

            //NSController.MissNote();
		//}

        // Don't show the 'hit' or 'failed' icon
		//GreenCheck.SetActive(false);
		//RedCheck.SetActive(false);
	}

    /// <summary>
    /// Plays the note's sound effect.
    /// </summary>
	public void PlayNote()
    {
        Debug.Log("Play(): Entered");
		sheetaudio.Play();
	}

}
