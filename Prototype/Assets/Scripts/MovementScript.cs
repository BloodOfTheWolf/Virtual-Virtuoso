using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {

	public float speed;
	Rigidbody rb;
	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 force = this.transform.position += new Vector3 (1, 0, 0) * speed*Time.deltaTime;
		rb.AddForce (force);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Bar") 
		{

		}

	}
}
