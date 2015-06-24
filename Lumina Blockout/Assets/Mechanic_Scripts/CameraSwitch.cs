using UnityEngine;
using System.Collections;

public class CameraSwitch : MonoBehaviour 
{

	public Camera cam1;

	public bool inputHasChanged;

	void  Start ()
	{
		cam1.GetComponent<Camera>().enabled = false;
	}


	void  OnTriggerStay ( Collider Col  )
	{
		if(Col.tag == "Player")
		{
			if(!PlayerControl.instance.isMoving && !inputHasChanged)
			{
				PlayerControl.instance.cameraTransform = cam1.transform;
				inputHasChanged = true;
			}

			cam1.GetComponent<Camera>().enabled = true;
		}
	}

	void OnTriggerExit (Collider Col)
	{
		if(Col.tag == "Player")
		{
			cam1.GetComponent<Camera>().enabled = false;
			inputHasChanged = false;
		}
	}
	
}
