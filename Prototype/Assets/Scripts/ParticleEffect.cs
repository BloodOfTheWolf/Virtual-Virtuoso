using UnityEngine;
using System.Collections;

public class ParticleEffect : MonoBehaviour 
{
	void Start () 
    {
        var exp = GetComponent<ParticleSystem>();
        Destroy( gameObject, exp.duration );
	}
}
