using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Results_RankScript : MonoBehaviour
{
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

    private NoteStreakControllerScript Results;
	private PlayerScoreInfoScript Cash;
	private float Total;
	private float Good;
	private float Rank;


    SFXControllerScript SFXController;
	

	void Start()
    {
        SFXController = GameObject.Find( "SFXController" ).GetComponent<SFXControllerScript>();

        Total = NoteStreakControllerScript.Total;
        Good = NoteStreakControllerScript.Hit;

		Intermediate = GameObject.Find("Intermediate Objects");
		Intermediate.SetActive(false);

		Advanced = GameObject.Find("Expert Objects");
		Advanced.SetActive(false);

		Rank = Good / Total;
		print (Rank);
		if (Rank <= 0.5f)
        {
            SFXController.SmlApplause();

			LetterF.SetActive (true);

			LetterAplus.SetActive(false);
			LetterA.SetActive(false);
			LetterB.SetActive(false);
			LetterC.SetActive(false);
			LetterD.SetActive(false);
            Clear.SetActive( false );
			TryAgain.SetActive (true);
			print ("Rank F");
			PlayerScoreInfoScript.PlayerMoney += 10;
			print ("Total money : " +PlayerScoreInfoScript.PlayerMoney);

		}
		else if (Rank <= 0.7f)
        {
            SFXController.SmlApplause();

			LetterD.SetActive (true);

			LetterAplus.SetActive(false);
			LetterA.SetActive(false);
			LetterB.SetActive(false);
			LetterC.SetActive(false);
			LetterF.SetActive(false);
			Clear.SetActive(true);
			TryAgain.SetActive(false);
			print ("Rank D");
			PlayerScoreInfoScript.PlayerMoney += 30;
			print ("Total money : " +PlayerScoreInfoScript.PlayerMoney);
		}
		else if (Rank <= 0.8f)
        {
            SFXController.MedApplause();

			LetterC.SetActive (true);

			LetterAplus.SetActive(false);
			LetterA.SetActive(false);
			LetterB.SetActive(false);
			LetterF.SetActive(false);
			LetterD.SetActive(false);
			Clear.SetActive(true);
			TryAgain.SetActive(false);
			print ("Rank C");
			PlayerScoreInfoScript.PlayerMoney += 40;
			print ("Total money : " +PlayerScoreInfoScript.PlayerMoney);
		}
		else if (Rank <= 0.9f)
        {
            SFXController.MedApplause();

			LetterB.SetActive (true);

			LetterAplus.SetActive(false);
			LetterA.SetActive(false);
			LetterF.SetActive(false);
			LetterC.SetActive(false);
			LetterD.SetActive(false);
			Clear.SetActive(true);
			TryAgain.SetActive(false);
			PlayerScoreInfoScript.PlayerMoney += 50;
			print ("Total money : " +PlayerScoreInfoScript.PlayerMoney);
		} 
		else if (Rank <= 0.95f)
        {
            SFXController.LrgApplause();

			LetterA.SetActive (true);

			LetterAplus.SetActive(false);
			LetterF.SetActive(false);
			LetterB.SetActive(false);
			LetterC.SetActive(false);
			LetterD.SetActive(false);
			Clear.SetActive(true);
			TryAgain.SetActive(false);
			PlayerScoreInfoScript.PlayerMoney += 70;
			print ("Total money : " +PlayerScoreInfoScript.PlayerMoney);
		}
		else 
		{
            SFXController.MsvApplause();

			LetterAplus.SetActive(true);

			LetterF.SetActive(false);
			LetterA.SetActive(false);
			LetterB.SetActive(false);
			LetterC.SetActive(false);
			LetterD.SetActive(false);
			Clear.SetActive(true);
			TryAgain.SetActive(false);
			PlayerScoreInfoScript.PlayerMoney += 80;
			print ("Total money : " + PlayerScoreInfoScript.PlayerMoney);
		}
	}
	
	void Update() 
	{
        SFXController = GameObject.Find( "SFXController" ).GetComponent<SFXControllerScript>();
	}
}
