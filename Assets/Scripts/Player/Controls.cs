using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {

    private int forwardAxis;
	private int sidewaysAxis;
	private float XAngle;
	private float YAngle;


	GameObject player;
	
	PlayerMovement playerMove;

	GameObject gocamera;
	CameraController cam;

	PlayerInteraction playerInteraction;

	// Use this for initialization
	void Start ()
	{
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
		player = GameObject.Find("Player");
		playerMove = player.GetComponent<PlayerMovement>();
		gocamera = Camera.main.gameObject;
		cam = gocamera.GetComponent<CameraController>();

		playerInteraction = player.GetComponent<PlayerInteraction>();
	}
	
	
	void FixedUpdate ()
    {
		Cursor.visible = false;

		if (Input.GetAxis("Vertical") > 0)
		{
			forwardAxis = 1;
			//forwardAxis = transform.forward;
		}
		else if (Input.GetAxis("Vertical") < 0)
		{
			forwardAxis = -1;
		}
		else
		{
			forwardAxis = 0;
		}
		

		if (Input.GetAxis("Horizontal") > 0)
		{
			sidewaysAxis = 1;
		}
		else if (Input.GetAxis("Horizontal") < 0)
		{
			sidewaysAxis = -1;
		}
		else
		{
			sidewaysAxis = 0;
		}




		XAngle = Input.GetAxis("Mouse X");
		YAngle = Input.GetAxis("Mouse Y");
		

		//playerMove.moveForward(forwardAxis);
		//playerMove.moveSideways(sidewaysAxis);
		playerMove.move(forwardAxis, sidewaysAxis);
		playerMove.rotate(XAngle);
		cam.upAngle(YAngle);


		if(Input.GetMouseButtonDown(0))
		{
			//playerInteraction.interact();
			playerInteraction.IsUse = true;
		}

	}
}
