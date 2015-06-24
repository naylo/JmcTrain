using UnityEngine;
using System.Collections;

public class MusicScript : MonoBehaviour 
{

	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.tag == "Player")
		{
			gameObject.GetComponent<AudioSource>().Play();
		}
	}

	void OnTriggerExit(Collider col)
	{
		if(col.gameObject.tag == "Player")
		{
			gameObject.GetComponent<AudioSource>().Stop();
		}
	}

}
