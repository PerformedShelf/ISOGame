using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
	public float maxSpeed;
	public float speedReduction;
	public float tilt;

	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		float moveHorizontal;

		if(Input.GetKey(KeyCode.UpArrow))
		{
			moveHorizontal = speedReduction;
		}
		else if(Input.GetKey(KeyCode.W))
		{
			moveHorizontal = speedReduction;
		}
		else moveHorizontal = Input.GetAxis("Vertical");
		
		float moveVertical = -Input.GetAxis("Horizontal");

		Vector3 movement = new Vector3
		(
			moveHorizontal, 
			0.0f, 
			moveVertical 
		);

		rb.velocity = movement * maxSpeed;
		rb.rotation = Quaternion.Euler(rb.velocity.z * tilt, 0.0f, 0.0f);
	}
}
