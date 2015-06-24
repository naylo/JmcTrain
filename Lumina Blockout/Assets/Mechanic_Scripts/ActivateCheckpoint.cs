using UnityEngine;
using System.Collections;

public class ActivateCheckpoint : MonoBehaviour 
{
	void OnTriggerStay(Collider other)
	{
		if(other.gameObject.tag == "Player" && Input.GetKey(KeyCode.C))
		{
			TeleportToCheckPoint.instance.isfound = true;
		}
	}
}
