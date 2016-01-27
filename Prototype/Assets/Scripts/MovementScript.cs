using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour
{
    GameObject MovementController;
	public float speed;
	Rigidbody rb;
	
	void Start () 
	{
		rb = GetComponent<Rigidbody>();
        MovementController = GameObject.Find("MovementController");

        speed = MovementController.GetComponent<MovementController>().MovementSpeed;
        speed *= -1;
	}
	
	void Update() 
	{
		Vector3 force = this.transform.position += new Vector3(1, 0, 0) * speed*Time.deltaTime;
		rb.AddForce(force);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Bar") 
		{

		}
	}
}
