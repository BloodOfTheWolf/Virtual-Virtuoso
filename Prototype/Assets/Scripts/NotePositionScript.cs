using UnityEngine;
using System.Collections;

public class NotePositionScript : MonoBehaviour
{
    /// <summary>
    /// Types of notes.
    /// </summary>
    public enum Note
    {
        A,
        B,
        C,
        D,
        E,
        F,
        G,
    };

    /// <summary>
    /// Types of accidentals.
    /// </summary>
    public enum Accidental
    {
        Natural,
        Sharp
    };

    /// <summary>
    /// What type of note (letter) is this?
    /// </summary>
    public Note NoteType;

    /// <summary>
    /// What octave is this note?
    /// </summary>
    public int NoteOctave = 1;

    /// <summary>
    /// Is this note a natural or a sharp?
    /// </summary>
    public Accidental AccidentalType = Accidental.Natural;

    /// <summary>
    /// What is the note's Y-position?
    /// </summary>
    float NoteY;

    /// <summary>
    /// If a note's height is lesser than this, it's octave 1.
    /// </summary>
    float Octave1Ceiling = 2.0f;

    /// <summary>
    /// If a note's height is lesser than this, it's octave 2.
    /// </summary>
    float Octave2Ceiling = 4.0f;

	void Start()
    {
        NoteY = gameObject.transform.position.y;

        // Set the note's octave
        SetOctave();

        // Fix the note's Y-position
        AdjustNotePosition();
	}

    /// <summary>
    /// Call this to set the note's octave based on its /NoteY/.
    /// </summary>
    void SetOctave()
    {
        // Is the note's Y-position smaller than the octave 2 ceiling?
        if( NoteY < Octave2Ceiling )
        {
            // Is the note's Y-position smaller than the octave 1 ceiling?
            if( NoteY < Octave1Ceiling )
            {
                NoteOctave = 1;
            }
            else
            {
                NoteOctave = 2;
            }
        }
        else
        {
            NoteOctave = 3;
        }
    }

    /// <summary>
    /// Call this to correct the note's Y-position based on its /NoteOctave/ and /NoteType/.
    /// </summary>
    void AdjustNotePosition()
    {
        // What are we setting the Y-position to?
        var NewYPosition = 0.0f;

        // Determine the proper Y-position to set the note to
        switch( NoteType )
        {
        case Note.A:
            switch( NoteOctave )
            {
            case 2:
                NewYPosition = 2.2f;
            break;
            case 3:
                NewYPosition = 4.625f;
            break;
            }
        break;
        case Note.B:
            switch( NoteOctave )
            {
            case 2:
                NewYPosition = 2.575f;
            break;
            case 3:
                NewYPosition = 5.0f;
            break;
            }
        break;
        case Note.C:
            switch( NoteOctave )
            {
            case 1:
                NewYPosition = 0.575f;
            break;
            case 2:
                NewYPosition = 2.9f;
            break;
            case 3:
                NewYPosition = 5.325f;
            break;
            }
        break;
        case Note.D:
            switch( NoteOctave )
            {
            case 1:
                NewYPosition = 0.9f;
            break;
            case 2:
                NewYPosition = 3.25f;
            break;
            }
        break;
        case Note.E:
            switch( NoteOctave )
            {
            case 1:
                NewYPosition = 1.225f;
            break;
            case 2:
                NewYPosition = 3.575f;
            break;
            }
        break;
        case Note.F:
            switch( NoteOctave )
            {
            case 1:
                NewYPosition = 1.55f;
            break;
            case 2:
                NewYPosition = 3.925f;
            break;
            }
        break;
        case Note.G:
            switch( NoteOctave )
            {
            case 1:
                NewYPosition = 1.9f;
            break;
            case 2:
                NewYPosition = 4.25f;
            break;
            }
        break;
        }

        // Set the note's new position
        gameObject.transform.position.Set( gameObject.transform.position.x, NewYPosition, gameObject.transform.position.z );
    }
}
