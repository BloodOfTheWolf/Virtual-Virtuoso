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
    private SheetNoteScript Score;
    private float width = 0.25f;
    private float height = 0.25f;

	void Start () 
    {
        if ((SheetNoteScript.Hit/SheetNoteScript.Total) > 0.5)
        {
            StarFillOne.SetActive( true );
        }
        if( (SheetNoteScript.Hit / SheetNoteScript.Total) > 0.75 )
        {
            StarFillTwo.SetActive( true );
        }
        if( (SheetNoteScript.Hit / SheetNoteScript.Total) > 0.9 )
        {
            StarFillThree.SetActive( true );
        }
	}
	
	void Update () 
    {
        if (width >= 2.0f)
        {
            width = 2.0f;
            height = 2.0f;
        }
        else
        {
            width += 0.05f;
            height += 0.05f;
        }

        if( (SheetNoteScript.Hit / SheetNoteScript.Total) > 0.5 )
        {
            StarOneGraphic.rectTransform.localScale = new Vector2( width, height );
        }

        if( (SheetNoteScript.Hit / SheetNoteScript.Total) > 0.5 )
        {
            StarTwoGraphic.rectTransform.localScale = new Vector2( width, height );
        }

        if( (SheetNoteScript.Hit / SheetNoteScript.Total) > 0.5 )
        {
            StarThreeGraphic.rectTransform.localScale = new Vector2( width, height );
        }
	}
}
