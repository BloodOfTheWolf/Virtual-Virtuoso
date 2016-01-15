using UnityEngine;
using System.Collections;


[RequireComponent(typeof(AudioSource))]


public class SheetNoteScript : MonoBehaviour {

	static SheetNoteScript Instance = null;
	AudioSource sheetaudio;
	public GameObject GreenCheck;
	public GameObject RedCheck;
	public static int Score;
	public static int NoteStreak;
	public static int HighestStreak;
	public static int Multiplier = 10;
	public static int LoseStreak;
	public static int Hit;
	public static int Miss;
	public static float Total;
	Camera cam;
	float height, width;
    private bool Colored;
    private GameObject Tutorial;
    public GameObject HitEffect;    // The ParticleSystem prefab we want to spawn when the player plays this note.
    public GameObject MissEffect;   // The ParticleSystem prefab we want to spawn when the player misses this note.
    Vector3 HitLocation;

    GameObject SFXController;

	public static SheetNoteScript GetInstance()
	{
		if (Instance == null) 
		{
			Instance = new SheetNoteScript();

		}
		return Instance;
	}

	// Use this for initialization
	void Start () 
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

        Tutorial = gameObject.transform.GetChild(0).GetChild(0).gameObject;
        if( Colored == false )
        {
            Tutorial.SetActive( false );

        }

        // AG 07-Jan-16
        // Get the center of the sprite and set the particle effect's spawn location
        var SpriteCenter = gameObject.GetComponentInChildren<SpriteRenderer>().bounds.extents.x;
        HitLocation = gameObject.transform.position - new Vector3( SpriteCenter, 0f, 0f );

	}
	// Need to get the SFX Controller object
	void Update () 
	{
        SFXController = GameObject.Find( "SFXController" );
	}

	void OnTriggerEnter(Collider other)
	{

		if (this.tag == other.tag) 
		{
			GreenCheck.SetActive(true);
			this.gameObject.SetActive(false);
			RedCheck.SetActive(false);
			Score = Score + Multiplier;
			NoteStreak++;
			Hit++;
			Total++;
			if(NoteStreak >= HighestStreak)
			{
				HighestStreak = NoteStreak;
				print ("Highest streak =" + HighestStreak);
			}
			print ("NoteStreak: " + NoteStreak);
			LoseStreak = 0;
			if(NoteStreak == 3 )
			{
                SFXController.GetComponent<SFXControllerScript>().MultiplierIncrease();
				Multiplier = Multiplier * 2;
			}
            
            //these are the additional multipliers, we need these later (and the math needs to be reworked to do 10 x2, x3, and x4)
            if( NoteStreak == 6 )
            {
                SFXController.GetComponent<SFXControllerScript>().MultiplierIncrease();
                Multiplier = Multiplier * 2;
            }
            if( NoteStreak == 9 )
            {
                SFXController.GetComponent<SFXControllerScript>().MultiplierIncrease();
                Multiplier = Multiplier * 2;
            }
			//sheetaudio.Play();
			//Debug.Break();

            // AG 07-Jan-16
            // Play our hit effect
            PlayParticleEffect( HitEffect );
		}



	}

    // AG 07-Jan-16
    // Plays the specified particle effect at the gameObject's location and rotation.
    void PlayParticleEffect(GameObject pfx)
    {
        Instantiate( pfx, gameObject.transform.position, Quaternion.identity );
    }

	void OnTriggerExit(Collider other)
	{
		if (GreenCheck.activeInHierarchy || !(GreenCheck.activeInHierarchy)) // if you miss
		{
            SFXController.GetComponent<SFXControllerScript>().NoteFail();
			RedCheck.SetActive(true);
			GreenCheck.SetActive(false);
			print ("trigger exit called");
			NoteStreak = 0;
			Multiplier = 10;
			LoseStreak = LoseStreak +1;
			Miss++;
			Total++;
			if(LoseStreak == 15)
			{
				//Application.isPlaying = false;
			}

		}

		//GreenCheck.SetActive (false);
		//RedCheck.SetActive (false);

	}

	void OnGUI()
	{
		GUIStyle style = new GUIStyle();
		style.fontSize = 30;
		GUI.Label (new Rect(Screen.width/2 + 200,height + 10,100,100),"Score: "+Score.ToString(),style);
		GUI.Label (new Rect(Screen.width/2 - 200, height + 10,100,100),"NoteStreak: "+NoteStreak.ToString(),style);
		
	}

	public void PlayNote()
	{
		sheetaudio.Play ();
	}
}
