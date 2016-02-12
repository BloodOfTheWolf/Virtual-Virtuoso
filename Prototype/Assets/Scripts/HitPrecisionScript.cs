using UnityEngine;
using System.Collections;

public class HitPrecisionScript : MonoBehaviour {

    GameObject Miss;
    GameObject Good;
    GameObject Great;
    GameObject Perfect;

    void Start()
    {
        Miss = gameObject.transform.GetChild(0).gameObject;
        Good = gameObject.transform.GetChild(1).gameObject;
        Great = gameObject.transform.GetChild(2).gameObject;
        Perfect = gameObject.transform.GetChild(3).gameObject;
        Miss.SetActive( false );
        Good.SetActive( false );
        Great.SetActive( false );
        Perfect.SetActive( false );
    }

   void MessageShow(int num)
    {
       switch(num)
       {
       case 0:

        Miss.SetActive( true );
        Good.SetActive( false );
        Great.SetActive( false );
        Perfect.SetActive( false );
        break;

       case 1:
       Miss.SetActive( false );
        Good.SetActive( true );
        Great.SetActive( false );
        Perfect.SetActive( false );
        break;

       case 2:
       Miss.SetActive( false );
        Good.SetActive( false );
        Great.SetActive( true );
        Perfect.SetActive( false );
        break;

       case 3:
       Miss.SetActive( false );
        Good.SetActive( false );
        Great.SetActive( false );
        Perfect.SetActive( true );
        break;
       }
    }
}
