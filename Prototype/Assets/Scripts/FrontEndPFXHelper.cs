using UnityEngine;
using System.Collections;

public class FrontEndPFXHelper : MonoBehaviour 
{
    void Awake()
    {
        DontDestroyOnLoad( transform.gameObject );
    }
}
