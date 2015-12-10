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

	}
	// Update is called once per frame
	void Update () 
	{
		
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
				Multiplier = Multiplier * 2;
			}
			//sheetaudio.Play();
			//Debug.Break();
		}



	}

	void OnTriggerExit ( Collider other)
	{
		if (GreenCheck.activeInHierarchy || !(GreenCheck.activeInHierarchy)) // if you miss
		{
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
				UnityEditor.EditorApplication.isPlaying = false;
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
