using UnityEngine;
using System.Collections;

public class DialogueManager : MonoBehaviour 
{

	void Start()
	{
		InputManager.instance.onButtonNeutral += NeutralChoice;
		InputManager.instance.onButtonDirect += DirectChoice;
		InputManager.instance.onButtonPersonalResponsibility += PersonalResponsibilityChoice;
		InputManager.instance.onButtonNurturing += NurturingChoice;
		InputManager.instance.onButtonDistracting += DistractingChoice;
		InputManager.instance.onButtonDamaging += DamagingChoice;
	}

	void NeutralChoice(int value)
	{
		MentalStateManager.instance.MentalStateCollectNeutral (5);

	}

	void DirectChoice(int value)
	{
		MentalStateManager.instance.MentalStateCollectDirect (5);
	}

	void PersonalResponsibilityChoice(int value)
	{
		MentalStateManager.instance.MentalStateCollectPersonalResponsibility (5);
	}

	void NurturingChoice (int value)
	{
		MentalStateManager.instance.MentalStateCollectNurturing (5);
	}

	void DistractingChoice (int value)
	{
		MentalStateManager.instance.MentalStateCollectDistracting (5);
	}

	void DamagingChoice (int value)
	{
		MentalStateManager.instance.MentalStateCollectDamaging (5);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
