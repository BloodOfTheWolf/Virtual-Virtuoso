using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NoteStreakControllerScript : MonoBehaviour
{
    // Multiplier graphics
    public Image[] fillImages;

    /// The player's score.
    public static int Score;

    /// The total number of notes the player played successfully. Primarily used for the results screen.
    public static int Hit;

    /// The total number of notes the player missed. Primarily used for the results screen.
    public static int Miss;

    /// The total number of notes in the song.  Primarily used for the results screen.
    public static float Total;

    /// The notestreak value.
    public static int NoteStreak;

    /// The player's highest streak obtained.
    public static int HighestStreak;

    /// The multiplier's current value.
    public static int MultiplierCurValue = 10;

    /// The multiplier's base value.
    public static int MultiplierBaseValue = 10;

    /// The losestreak value.
    public static int LoseStreak;

    /// The ParticleSystem to spawn when the Notestreak multiplier increases.
    public GameObject NotestreakMultiplierIncreaseEffect;

    /// The Vector3 position of the notestreak multiplier UI object.
    Vector3 NotestreakMultiplierEffectPosition;

    /// <summary>
    /// The score's text object.
    /// </summary>
    public Text ScoreTextObject;

    /// <summary>
    /// The base text for the score.
    /// </summary>
    string ScoreTextBase = "SCORE: ";

    /// <summary>
    /// The numeric portion of the score.
    /// </summary>
    string ScoreTextValue = "0";

    public Text MultiplierTextObject;

    string MultiplierTextValue = "x1";

    /// Our audio controller object.
    GameObject SFXController;

    /// The screen's height and width. Used for GUI purposes.
    float height, width;


    void Start()
    {
        Score = 0;
        NoteStreak = 0;
        HighestStreak = 0;
        LoseStreak = 0;
        Hit = 0;
        Miss = 0;
        Total = 0.0f;

        MultiplierCurValue = 10;
        MultiplierBaseValue = 10;

        // 12 notestreak UI images
        fillImages = new Image[12];

        // For each notestreak UI image,
        for( int i = 0; i < fillImages.Length; i++ )
        {
            var iInt = i + 1;
            var iStr = "Fill" + iInt.ToString();

            //Debug.Log( "SheetNoteScript: Assigning " + iStr );

            // Assign the image component
            fillImages[i] = GameObject.Find( iStr ).GetComponentInChildren<Image>();

            // And hide it
            fillImages[i].enabled = false;
        }
    }


    void Update()
    {
        SFXController = GameObject.Find( "SFXController" );

        // Convert the score into a comma-separated number string
        ScoreTextValue = Score.ToString( "N0" );

        // Update the score text with the new score
        ScoreTextObject.text = ScoreTextBase + ScoreTextValue;

        var MultiplierVal = MultiplierCurValue / 10;

        MultiplierTextObject.text = "x" + MultiplierVal.ToString();
    }


    /// <summary>
    /// Updates the score, increments the note stats /Hit/ and /Total/, and updates the notestreak multiplier.
    /// </summary>
    public void HitNote()
    {
        // Update the score
        UpdateScore();

        // Increment the note stats
        Hit++;
        Total++;

        // Increment the notestreak value
        NoteStreak++;

        // Reset the losestreak
        LoseStreak = 0;

        // Update the notestreak multiplier
        UpdateNotestreakMultiplier();
    }


    /// <summary>
    /// Resets the notestreak multiplier, increments /LoseStreak/, and increments the note stats /Miss/ and /Total/.
    /// </summary>
    public void MissNote()
    {
        // Play the 'failed' sound ditty
        SFXController.GetComponent<SFXControllerScript>().NoteFail();

        // Increment the note stats
        Miss++;
        Total++;

        // Increment the losestreaks
        LoseStreak += 1;

        if( LoseStreak == 1 )
        {
            // Reset the notestreak multiplier
            ResetNotestreakMultiplier();
        }

        UpdateNotestreakMultiplier();
    }


    /// <summary>
    /// Updates /Score/ based on /MultiplierCurValue/.
    /// </summary>
    public void UpdateScore()
    {
        // Update the score
        Score += MultiplierCurValue;
    }


    // AG 19-Jan-16
    /// <summary>
    /// Updates the notestreak multiplier.
    /// </summary>
    public void UpdateNotestreakMultiplier()
    {

        // Update the highest streak if appropriate
        if( NoteStreak >= HighestStreak )
        {
            HighestStreak = NoteStreak;
            //print( "Highest streak =" + HighestStreak );
        }

        // Print the values to the log
        //print( "NoteStreak: " + NoteStreak );


        // *********************
        // MULTIPLIER START

        // TODO: Fix NotestreakMultiplierEffectPosition's value.
        // Set the position of the 'notestreak multiplier increment' particle effect
        NotestreakMultiplierEffectPosition = new Vector3( 0, 0, 0 );
       // print( NotestreakMultiplierEffectPosition.ToString() );
        //print( gameObject.transform.position.ToString() );


        if( NoteStreak > 0 )
        {
            if( NoteStreak <= 12 )
            {
                // Update the notestreak images depending on which one we're on
                fillImages[NoteStreak - 1].enabled = true;
            }

            // x2 Multiplier
            if( NoteStreak == 3 )
            {
                // Play the 'multiplier increase' sound ditty
                SFXController.GetComponent<SFXControllerScript>().MultiplierIncrease();

                // Spawn the 'notestreak multiplier increment' particle effect
                //PlayParticleEffect( NotestreakMultiplierIncreaseEffect, NotestreakMultiplierEffectPosition );

                // Double the multiplier value
                MultiplierCurValue *= 2;
            }

            // x3 Multiplier(?)
            if( NoteStreak == 6 )
            {
                // Play the 'multiplier increase' sound ditty
                SFXController.GetComponent<SFXControllerScript>().MultiplierIncrease();

                // Spawn the 'notestreak multiplier increment' particle effect
                //PlayParticleEffect( NotestreakMultiplierIncreaseEffect, NotestreakMultiplierEffectPosition );

                // Double the multiplier value
                MultiplierCurValue *= 2;
            }

            // x4 Multiplier(?)
            if( NoteStreak == 9 )
            {
                // Play the 'multiplier increase' sound ditty
                SFXController.GetComponent<SFXControllerScript>().MultiplierIncrease();

                // Spawn the 'notestreak multiplier increment' particle effect
                //PlayParticleEffect( NotestreakMultiplierIncreaseEffect, NotestreakMultiplierEffectPosition );

                // Double the multiplier value
                MultiplierCurValue *= 2;
            }
        }

        // MULTIPLIER END
        // *********************
    }


    /// <summary>
    /// Resets /NoteStreak/ to 0 and updates the notestreak multiplier.
    /// </summary>
    public void ResetNotestreakMultiplier()
    {
        // Reset the notestreak
        NoteStreak = 0;

        // For each notestreak UI image,
        for( int i = 0; i < fillImages.Length; i++ )
        {
            var iInt = i + 1;
            var iStr = "Fill" + iInt.ToString();

            // And hide it
            fillImages[i].enabled = false;
        }

        // Play a sound ditty and reset the multiplier
        SFXController.GetComponent<SFXControllerScript>().MultiplierFail();
        MultiplierCurValue = 10;
    }


    // AG 07-Jan-16
    /// <summary>
    /// Plays the specified ParticleSystem prefab /pfx/ at the specified location /spawnLocation/.
    /// </summary>
    /// <param name="pfx">Particle effect to spawn</param>
    /// <param name="spawnLocation">Location in which to spawn</param>
    /// 
    public void PlayParticleEffect( GameObject pfx, Vector3 spawnLocation )
    {
        Instantiate( pfx, spawnLocation, Quaternion.identity );
    }
    

    // HUD work
    //void OnGUI()
    //{
        // Initialize the GUI constructor
        //GUIStyle style = new GUIStyle();

        // Set the font size
        //style.fontSize = 15;

        // Draw the temporary text for the score and notestreak
        //GUI.Label( new Rect( (Screen.width / 2 + 200), (height + 10), 100, 100 ), "Score: " + Score.ToString(), style );
        //GUI.Label( new Rect( (Screen.width / 2 - 200), (height + 10), 100, 100 ), "NoteStreak: " + NoteStreak.ToString(), style );
    //}
}
