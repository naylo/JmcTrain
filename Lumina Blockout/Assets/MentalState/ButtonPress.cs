using UnityEngine;
using System.Collections;

public class ButtonPress : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}

	public void ButtonPressing()
	{
		MentalStateManager.instance.MentalStateCollectNeutral (1);
	}
	

}
