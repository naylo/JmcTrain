using UnityEngine;
using System.Collections;

public class NewCameraScript : MonoBehaviour 
{
	public Camera cam1;
	
	void Start () 
	{
		cam1.GetComponent<Camera>().enabled = false;
	}

	void OnTriggerStay (Collider Col) 
	{
		if(Col.tag == "Player")
		{
			
			PlayerControl.instance.cameraTransform = cam1.transform;

			cam1.GetComponent<Camera>().enabled = true;
		}
	}

	void OnTriggerExit (Collider Col)
	{
		if(Col.tag == "Player")
		{
			cam1.GetComponent<Camera>().enabled = false;
		}
	}
}
