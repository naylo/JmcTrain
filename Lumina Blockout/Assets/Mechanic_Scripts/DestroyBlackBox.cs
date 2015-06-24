using UnityEngine;
using System.Collections;

public class DestroyBlackBox : MonoBehaviour 
{


	void OnTriggerStay (Collider other) 
	{
		if (Input.GetKey(KeyCode.Z))
		{
			Destroy(gameObject);
		}
	}
}
