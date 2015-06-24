using UnityEngine;
using System.Collections;

public class CubeDamage : MonoBehaviour 
{
	
	public float cubeDamage = 1;

	void OnTriggerStay (Collider colider)
	{
		if(colider.tag == "Sister")
		{
			//MentalState.instance.damageAmount = cubeDamage.Equals (cubeDamage);
			MentalState.instance.UpdateMentalState(-(cubeDamage * Time.deltaTime));
			//MentalState.instance.mentalState -= cubeDamage * Time.deltaTime;


		}

	}

}
