using UnityEngine;
using System.Collections;

public class FinishGame : MonoBehaviour 
{
	public GameObject msm;

	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			msm.GetComponent<MentalStateManager>().MentalStateTotal();
		}
	}
}
