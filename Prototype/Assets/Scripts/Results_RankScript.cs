using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Results_RankScript : MonoBehaviour {

	public GameObject LetterAplus;
	public GameObject LetterA;
	public GameObject LetterB;
	public GameObject LetterC;
	public GameObject LetterD;
	public GameObject LetterF;
	public GameObject TryAgain;
	public GameObject Clear;

	private SheetNoteScript Results;
	private float Total;
	private float Good;
	private float Rank;
	// Use this for initialization
	void Start () 
	{
		Total = SheetNoteScript.Total;
		Good = SheetNoteScript.Hit;
		Rank = Good / Total;
		print (Rank);
		if (Rank <= 0.5f) {
			LetterF.SetActive (true);
			TryAgain.SetActive (true);
            print( "rank f" );
		}
		else if (Rank <= 0.6f) 
		{
			LetterD.SetActive (true);
			Clear.SetActive(true);
            print( "rank d" );
		}
		else if (Rank <= 0.7f) 
		{
			LetterC.SetActive (true);
			Clear.SetActive(true);
            print( "rank c" );
		}
		else if (Rank <= 0.8f) 
		{
			LetterB.SetActive (true);
			Clear.SetActive(true);
            print( "rank b" );
		} 
		else if (Rank <= 0.9f) 
		{
			LetterA.SetActive (true);
			Clear.SetActive(true);
            print( "rank a" );
		}
		else 
		{
			LetterAplus.SetActive(true);
			Clear.SetActive(true);
            print( "rank cap" );
		}
	}
	
	// Update is called once per frame
	void Update () 
	{

	
	}
}
