using UnityEngine;
using System.Collections;

public class ChangetoWasteland : MonoBehaviour 
{
	public GameObject msm;

	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			msm.GetComponent<MentalStateManager>().MentalStateSave();
			Application.LoadLevel("Wasteland");
		}
	}
}
