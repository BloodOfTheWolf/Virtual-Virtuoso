using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Results_StarControlScript : MonoBehaviour 
{
    public GameObject StarFillOne;
    public GameObject StarFillTwo;
    public GameObject StarFillThree;
    public Image StarOneGraphic;
    public Image StarTwoGraphic;
    public Image StarThreeGraphic;
    private NoteStreakControllerScript Score;
    private float width = 0.25f;
    private float height = 0.25f;

    public static int StarLevel = 0;

	void Start () 
    {
        print( "notestreak hit = " + NoteStreakControllerScript.Hit );
        print( "notestreak total = " + NoteStreakControllerScript.Total );
        print( "after operation = " +( NoteStreakControllerScript.Hit / NoteStreakControllerScript.Total) );
        if( (NoteStreakControllerScript.Hit / NoteStreakControllerScript.Total) > 0.5 )
        {
            print( "entered 1 star" );
            StarFillOne.SetActive( true );
            StarLevel = 1;
        }
        if( (NoteStreakControllerScript.Hit / NoteStreakControllerScript.Total) > 0.75 )
        {
            print( "entered 2 star" );
            StarFillTwo.SetActive( true );
            StarLevel = 2;
        }
        if( (NoteStreakControllerScript.Hit / NoteStreakControllerScript.Total) > 0.9 )
        {
            print( "entered 3 star" );
            StarFillThree.SetActive( true );
            StarLevel = 3;
        }
	}
	
	void Update() 
    {
        if (width >= 1.0f)
        {
            width = 1.0f;
            height = 1.0f;
        }
        else
        {
            width += 0.05f;
            height += 0.05f;
        }

        if( (NoteStreakControllerScript.Hit / NoteStreakControllerScript.Total) > 0.5 )
        {
            StarOneGraphic.rectTransform.localScale = new Vector2( width, height );
        }

        if( (NoteStreakControllerScript.Hit / NoteStreakControllerScript.Total) > 0.75 )
        {
            StarTwoGraphic.rectTransform.localScale = new Vector2( width, height );
        }

        if( (NoteStreakControllerScript.Hit / NoteStreakControllerScript.Total) > 0.9 )
        {
            StarThreeGraphic.rectTransform.localScale = new Vector2( width, height );
        }
	}
}
