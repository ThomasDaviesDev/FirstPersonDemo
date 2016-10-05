using UnityEngine;
using System.Collections;
using System;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed;
	public float turnSpeed;

	public float maxSpeed;

    private Rigidbody rb;
    
    // Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void FixedUpdate()
    {
		
    }

    public void moveForward(int direction)
    {
		//rb.velocity = transform.forward * moveSpeed * direction;
		//transform.position += transform.forward * moveSpeed * direction;
		rb.AddForce(transform.forward * moveSpeed * direction);
		
    }

	public void moveSideways(int direction)
	{
		//rb.velocity = transform.right * moveSpeed * direction;
		//transform.position += transform.right * moveSpeed * direction;
		rb.AddForce(transform.right * moveSpeed * direction);
	}

	public void move(int forwardDir, int sidewaysDir)
	{
		rb.AddForce(transform.forward * moveSpeed * forwardDir);
		rb.AddForce(transform.right * moveSpeed * sidewaysDir);
		rb.velocity = myMath.ClampVelocity(rb.velocity, maxSpeed);
	}

	public void rotate(float angle)
	{
		rb.transform.Rotate(Vector3.up * turnSpeed * angle);		
	}
}
