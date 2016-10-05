using UnityEngine;
using System.Collections;

public class Interactable : MonoBehaviour {


	//TODO remove colour changing stuff

	public enum interactState
	{
		none,
		hover,
		use
	}

	private interactState state;

	public string hoverText = "Interact";

	public Color idle;
	public Color hover;
	public Color use;

	public Material matIdle;
	public Material matHover;
	public Material matUse;

	Renderer rend;

	public bool isSelected;


	// Use this for initialization
	void Start ()
	{
		rend = GetComponent<Renderer>();
		rend.material.color = idle;
	}
	
	// Update is called once per frame
	void Update ()
	{
		setState("none");
	}

	public void setState(string stateString)
	{
		//state = stateString;
		state = (interactState) System.Enum.Parse(typeof(interactState), stateString);
		colourState();
	}

	public interactState getState()
	{
		return state;
	}

	void colourState()
	{
		switch (state)
		{
			case interactState.none:
				if (isSelected)
				{
					rend.material = matUse;
				}
				else
				{
					
					rend.material= matIdle;
					
				}
				break;
			case interactState.hover:

				rend.material.EnableKeyword("_EMISSION");
				rend.material.SetColor("_EmissionColor", Color.white * 0.3f);
				
				
				break;
			case interactState.use:
				if (isSelected)
				{
					isSelected = false;
					
				}
				else
				{
					isSelected = true;
					
				}

				rend.material = matUse;
				
				break;
			default:
				break;
		}

	}

	
}
