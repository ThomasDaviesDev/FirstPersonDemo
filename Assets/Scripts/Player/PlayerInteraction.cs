using UnityEngine;
using System.Collections;

public class PlayerInteraction : MonoBehaviour {

	Camera cam;
	Ray ray;
	RaycastHit hit;

	private bool isUse;

	public bool IsUse
	{
		get
		{
			return isUse;
		}

		set
		{
			isUse = value;
		}
	}

	// Use this for initialization
	void Start ()
	{
		cam = Camera.main;
		isUse = false;

		
	}
	
	
	void LateUpdate ()
	{
		if(!isUse)
		{
			interactHover();
		}
		else
		{
			
			interactUse();

			isUse = false;
		}
	}

	public void interactUse()
	{
		//RaycastHit hit;
		ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

		if (Physics.Raycast(ray, out hit))
		{
			if (hit.transform.tag == "Interactable")
			{
				hit.transform.gameObject.GetComponent<Interactable>().setState("use");
			}
		}
	}

	public void interactHover()
	{
		
		ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

		if (Physics.Raycast(ray, out hit))
		{
			if (hit.transform.tag == "Interactable")
			{
				hit.transform.gameObject.GetComponent<Interactable>().setState("hover");
				//Debug.Log (hit.transform.gameObject.GetComponent<Interactable>().getState().ToString());
			}
		}

	}



}
