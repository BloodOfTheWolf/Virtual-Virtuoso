using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SongSelectionSpriteScript : MonoBehaviour
{

    public Image TutorialSelected;
    public Image HotCrossSelected;
    public Image FurEliseSelected;
    public Image CanonSelected;
    public Image EntertainerSelected;
    public Image MountainKingSelected;
    public Image FreeplaySelected;

	void Start()
    {
        TutorialSelected.enabled = true;
        HotCrossSelected.enabled = false;
        FurEliseSelected.enabled = false;
        CanonSelected.enabled = false;
        EntertainerSelected.enabled = false;
        MountainKingSelected.enabled = false;
        FreeplaySelected.enabled = false;
	}
	
	public void TutorialActive()
    {
        TutorialSelected.enabled = true;
        HotCrossSelected.enabled = false;
        FurEliseSelected.enabled = false;
        CanonSelected.enabled = false;
        EntertainerSelected.enabled = false;
        MountainKingSelected.enabled = false;
        FreeplaySelected.enabled = false;
	}

    public void HotCrossActive()
    {
        TutorialSelected.enabled = false;
        HotCrossSelected.enabled = true;
        FurEliseSelected.enabled = false;
        CanonSelected.enabled = false;
        EntertainerSelected.enabled = false;
        MountainKingSelected.enabled = false;
        FreeplaySelected.enabled = false;
    }

    public void FurEliseActive()
    {
        TutorialSelected.enabled = false;
        HotCrossSelected.enabled = false;
        FurEliseSelected.enabled = true;
        CanonSelected.enabled = false;
        EntertainerSelected.enabled = false;
        MountainKingSelected.enabled = false;
        FreeplaySelected.enabled = false;
    }

    public void CanoninDSelected()
    {
        TutorialSelected.enabled = false;
        HotCrossSelected.enabled = false;
        FurEliseSelected.enabled = false;
        CanonSelected.enabled = true;
        EntertainerSelected.enabled = false;
        MountainKingSelected.enabled = false;
        FreeplaySelected.enabled = false;
    }

    public void TheEntertainerSelected()
    {
        TutorialSelected.enabled = false;
        HotCrossSelected.enabled = false;
        FurEliseSelected.enabled = false;
        CanonSelected.enabled = false;
        EntertainerSelected.enabled = true;
        MountainKingSelected.enabled = false;
        FreeplaySelected.enabled = false;
    }

    public void MountainKingActive()
    {
        TutorialSelected.enabled = false;
        HotCrossSelected.enabled = false;
        FurEliseSelected.enabled = false;
        CanonSelected.enabled = false;
        EntertainerSelected.enabled = false;
        MountainKingSelected.enabled = true;
        FreeplaySelected.enabled = false;
    }

    public void FreeplayActive()
    {
        TutorialSelected.enabled = false;
        HotCrossSelected.enabled = false;
        FurEliseSelected.enabled = false;
        CanonSelected.enabled = false;
        EntertainerSelected.enabled = false;
        MountainKingSelected.enabled = false;
        FreeplaySelected.enabled = true;
    }
}
