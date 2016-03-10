using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(AudioSource))]

public class PianoKeyScript : MonoBehaviour
{
    //public NoteSoundManager NoteScript;

    //public AudioClip SoundToPlay;

    /// <summary>
    /// Types of notes.
    /// </summary>
    //public enum Note
    //{
    //    A,
    //    B,
    //    C,
    //    D,
    //    E,
    //    F,
    //    G,
    //};

    /// <summary>
    /// Types of accidentals.
    /// </summary>
    //public enum Accidental
    //{
    //    Natural,
    //    Sharp
    //};

    /// <summary>
    /// What type of note (letter) is this?
    /// </summary>
    //public Note NoteType;

    /// <summary>
    /// What octave is this note?
    /// </summary>
    //public int NoteOctave = 1;

    /// <summary>
    /// Is this note a natural or a sharp?
    /// </summary>
    //public Accidental AccidentalType = Accidental.Natural;


	AudioSource audio;
	public GameObject barnotes;
	GameObject LitNote;
	private float NoteVol;
	private GameObject Tutorial;
	private bool Colored;
    private bool Dulcimer = false;

	private List<GameObject> TouchList = new List<GameObject>();
	private GameObject[] OldTouches;

    //private Ray ray;
    private RaycastHit RayHitInfo = new RaycastHit();
    //public static int CurrTouch =0;


	void Awake() 
	{
		Colored = ColorToggleScript.Toggle;
		// only to be done once. not in update
		audio = GetComponent<AudioSource>();
        switch(InstrumentToggleScript.Instrument)
        {
        case 1:
        audio.clip = Resources.Load<AudioClip>( "Dulcimer-Piano Audio/" + this.name + "Piano" );
        break;
        case 2:
        audio.clip = Resources.Load<AudioClip>( "Dulcimer-Piano Audio/" + this.name + "Dulc" );
        break;
        case 3:
        audio.clip = Resources.Load<AudioClip>( "Harps - Organ/" + this.name + "Harp" );
        break;
        case 4:
        audio.clip = Resources.Load<AudioClip>( "Harps - Organ/" + this.name + "Organ" );
        break;
        }
        //if(Dulcimer == false)
        //{
        //    audio.clip = Resources.Load<AudioClip>( "Dulcimer-Piano Audio/" + this.name + "Piano" );

        //}
        //else
        //{
        //    audio.clip = Resources.Load<AudioClip>( "Dulcimer-Piano Audio/" + this.name + "Dulc" );
        //}
		NoteVol = PianoVolumeScript.PKVolume;
		audio.volume = NoteVol;

		Tutorial = gameObject.transform.GetChild (1).gameObject;
		if (Colored == false) 
		{
		Tutorial.SetActive(false);

		}
		LitNote = gameObject.transform.GetChild (0).gameObject;
        //notesHitBox = GameObject.FindWithTag(ajorHitbox)


        // Get the NoteSoundManager script
        //NoteScript = GameObject.Find( "SFXController" ).GetComponent<NoteSoundManager>();

        //UpdateKeySound();
	}
		
	
	void Update()
	{
        if(Input.touches.Length > 0)
        {
			OldTouches = new GameObject[TouchList.Count];
			TouchList.CopyTo(OldTouches);
			TouchList.Clear();
			foreach(Touch touch in Input.touches)
			{
			Ray ray = Camera.main.ScreenPointToRay(touch.position);

			if(Physics.Raycast(ray , out RayHitInfo ))
			{
				GameObject recipient = RayHitInfo.transform.gameObject;
				TouchList.Add(recipient);

				if( touch.phase == TouchPhase.Began)
				{
					recipient.SendMessage("OnTouchDown");
				}
				if( touch.phase == TouchPhase.Ended)
				{
					recipient.SendMessage("OnTouchUp");
				}
			}



			}

			foreach(GameObject g in OldTouches)
			{
				if(!TouchList.Contains(g))
				{
				    g.SendMessage("OnTouchUp");
				}
			}
//            for(int i = 0; i < Input.touchCount ; i++)
//            {
//                CurrTouch = i;
//                if(Input.GetTouch(i).phase == TouchPhase.Began)
//                {
//                    ray = Camera.main.ScreenPointToRay( Input.GetTouch( i ).position );
//                    if(Physics.Raycast(ray, out RayHitInfo))
//                    {
//						OnMouseDown();
//                    }
//                }
//
//                if(Input.GetTouch(i).phase == TouchPhase.Ended)
//                {
//					OnMouseUp();
//                }
//
//            }
        }
	}
		
	void OnMouseDown()
	{

			audio.Play ();
			barnotes.SetActive (true);
			LitNote.SetActive (true);
	}
	void OnMouseUp()
	{

		barnotes.SetActive(false);
		LitNote.SetActive(false);
	}

	void OnTouchDown()
	{
		
		audio.Play();
		barnotes.SetActive (true);
		LitNote.SetActive (true);
	}
	void OnTouchUp()
	{
		
		barnotes.SetActive(false);
		LitNote.SetActive(false);
	}
		
	void OnTriggerEnter(Collider other)
	{
	}

    //void UpdateKeySound()
    //{
    //    // Determine the proper Y-position to set the note to
    //    switch( NoteType )
    //    {
    //    case Note.A:
    //        switch( NoteOctave )
    //        {
    //        case 2:
    //            if( AccidentalType == Accidental.Natural )
    //                { SoundToPlay = NoteScript.A2; }
    //            else{ SoundToPlay = NoteScript.A2_Sharp; }
    //        break;
    //        case 3:
    //            if( AccidentalType == Accidental.Natural )
    //                { SoundToPlay = NoteScript.A3; }
    //            else{ SoundToPlay = NoteScript.A3_Sharp; }
    //        break;
    //        }
    //    break;
    //    case Note.B:
    //        switch( NoteOctave )
    //        {
    //        case 2:
    //            if( AccidentalType == Accidental.Natural )
    //                { SoundToPlay = NoteScript.B2; }
    //            else{ SoundToPlay = NoteScript.B2; }
    //        break;
    //        case 3:
    //            if( AccidentalType == Accidental.Natural )
    //                { SoundToPlay = NoteScript.B3; }
    //            else{ SoundToPlay = NoteScript.B3; }
    //        break;
    //        }
    //    break;
    //    case Note.C:
    //        switch( NoteOctave )
    //        {
    //        case 1:
    //            if( AccidentalType == Accidental.Natural )
    //                { SoundToPlay = NoteScript.C1; }
    //            else{ SoundToPlay = NoteScript.C1_Sharp; }
    //        break;
    //        case 2:
    //            if( AccidentalType == Accidental.Natural )
    //                { SoundToPlay = NoteScript.C2; }
    //            else{ SoundToPlay = NoteScript.C2_Sharp; }
    //        break;
    //        }
    //    break;
    //    case Note.D:
    //        switch( NoteOctave )
    //        {
    //        case 1:
    //            if( AccidentalType == Accidental.Natural )
    //                { SoundToPlay = NoteScript.D1; }
    //            else{ SoundToPlay = NoteScript.D1_Sharp; }
    //        break;
    //        case 2:
    //            if( AccidentalType == Accidental.Natural )
    //                { SoundToPlay = NoteScript.D2; }
    //            else{ SoundToPlay = NoteScript.D2_Sharp; }
    //        break;
    //        }
    //    break;
    //    case Note.E:
    //        switch( NoteOctave )
    //        {
    //        case 1:
    //            if( AccidentalType == Accidental.Natural )
    //                { SoundToPlay = NoteScript.E1; }
    //            else{ SoundToPlay = NoteScript.E1; }
    //        break;
    //        case 2:
    //            if( AccidentalType == Accidental.Natural )
    //                { SoundToPlay = NoteScript.E2; }
    //            else{ SoundToPlay = NoteScript.E2; }
    //        break;
    //        }
    //    break;
    //    case Note.F:
    //        switch( NoteOctave )
    //        {
    //        case 1:
    //            if( AccidentalType == Accidental.Natural )
    //                { SoundToPlay = NoteScript.F1; }
    //            else{ SoundToPlay = NoteScript.F1_Sharp; }
    //        break;
    //        case 2:
    //            if( AccidentalType == Accidental.Natural )
    //                { SoundToPlay = NoteScript.F2; }
    //            else{ SoundToPlay = NoteScript.F2_Sharp; }
    //        break;
    //        }
    //    break;
    //    case Note.G:
    //        switch( NoteOctave )
    //        {
    //        case 1:
    //            if( AccidentalType == Accidental.Natural )
    //                { SoundToPlay = NoteScript.G1; }
    //            else{ SoundToPlay = NoteScript.G1_Sharp; }
    //        break;
    //        case 2:
    //            if( AccidentalType == Accidental.Natural )
    //                { SoundToPlay = NoteScript.G2; }
    //            else{ SoundToPlay = NoteScript.G2_Sharp; }
    //        break;
    //        }
    //    break;
    //    }

    //    // Set the note's play sound
    //    audio.clip = SoundToPlay;
    //}

}