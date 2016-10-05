using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	
	public float maxAngle; //clamp between 90 and 270
	//float currentAngle;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

	}

	public void upAngle(float angle)
	{
		transform.Rotate(Vector3.right * angle * -1);

		//float clampedXAngle = myMath.ClampAngle(transform.eulerAngles.x, -maxAngle, maxAngle);

		transform.eulerAngles = new Vector3(myMath.ClampAngle(transform.eulerAngles.x, -maxAngle, maxAngle), transform.eulerAngles.y, transform.eulerAngles.z);
		
		//Debug.Log(transform.eulerAngles);
	}
}
