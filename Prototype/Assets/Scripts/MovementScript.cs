using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour
{
    
	public float speed;
	
	void Start () 
	{

        if( MovementSliderScript.SpeedValue == 0 )
        {
            speed = 2;
        }
        else
        {
            speed = MovementSliderScript.SpeedValue;
        }
        speed *= -1;
	}
	
	void Update() 
	{
		Vector3 force = this.transform.position += new Vector3(1, 0, 0) * speed*Time.deltaTime;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Bar") 
		{

		}
	}
}
