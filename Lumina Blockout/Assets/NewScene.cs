using UnityEngine;
using System.Collections;

public class NewScene : MonoBehaviour 
{
	public GameObject msm;

	void Awake()
	{
		msm.GetComponent<MentalStateManager>().MentalStateLoad();
	}
}
