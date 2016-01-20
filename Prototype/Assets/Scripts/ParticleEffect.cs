using UnityEngine;
using System.Collections;

public class ParticleEffect : MonoBehaviour 
{
	void Start() 
    {
        // Store the object's ParticleSystem component
        var exp = GetComponent<ParticleSystem>();

        // Remove the object from the scene after it's expired
        Destroy( gameObject, exp.duration );
	}
}
