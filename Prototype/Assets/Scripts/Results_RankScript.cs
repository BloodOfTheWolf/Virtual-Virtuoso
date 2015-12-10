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

	private GameObject Intermediate;
	private GameObject Advanced;

	private SheetNoteScript Results;
	private float Total;
	private float Good;
	private float Rank;
	// Use this for initialization
	void Start () 
	{
		Total = SheetNoteScript.Total;
		Good = SheetNoteScript.Hit;

		Intermediate = GameObject.Find("Intermediate Objects");
		Intermediate.SetActive (false);

		Advanced = GameObject.Find("Expert Objects");
		Advanced.SetActive (false);

		Rank = Good / Total;
		print (Rank);
		if (Rank <= 0.5f)
		{
			LetterF.SetActive (true);

			LetterAplus.SetActive (false);
			LetterA.SetActive (false);
			LetterB.SetActive (false);
			LetterC.SetActive (false);
			LetterD.SetActive (false);
			TryAgain.SetActive (true);
			print ("Rank F");
		}
		else if (Rank <= 0.7f) 
		{
			LetterD.SetActive (true);

			LetterAplus.SetActive (false);
			LetterA.SetActive (false);
			LetterB.SetActive (false);
			LetterC.SetActive (false);
			LetterF.SetActive (false);
			Clear.SetActive(true);
			TryAgain.SetActive (false);
			print ("Rank D");
		}
		else if (Rank <= 0.8f) 
		{
			LetterC.SetActive (true);

			LetterAplus.SetActive (false);
			LetterA.SetActive (false);
			LetterB.SetActive (false);
			LetterF.SetActive (false);
			LetterD.SetActive (false);
			Clear.SetActive(true);
			TryAgain.SetActive (false);
			print ("Rank C");
		}
		else if (Rank <= 0.9f) 
		{
			LetterB.SetActive (true);

			LetterAplus.SetActive (false);
			LetterA.SetActive (false);
			LetterF.SetActive (false);
			LetterC.SetActive (false);
			LetterD.SetActive (false);
			Clear.SetActive(true);
			TryAgain.SetActive (false);
		} 
		else if (Rank <= 0.95f) 
		{
			LetterA.SetActive (true);

			LetterAplus.SetActive (false);
			LetterF.SetActive (false);
			LetterB.SetActive (false);
			LetterC.SetActive (false);
			LetterD.SetActive (false);
			Clear.SetActive(true);
			TryAgain.SetActive (false);
		}
		 else 
		{
			LetterAplus.SetActive(true);

			LetterF.SetActive (false);
			LetterA.SetActive (false);
			LetterB.SetActive (false);
			LetterC.SetActive (false);
			LetterD.SetActive (false);
			Clear.SetActive(true);
			TryAgain.SetActive (false);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{

	
	}
}
