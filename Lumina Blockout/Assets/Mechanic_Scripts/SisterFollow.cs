using UnityEngine;
using System.Collections;

public class SisterFollow : MonoBehaviour 
{
	
	public static SisterFollow instance;

	public Transform Leader;

	void Awake()
	{
		instance = this;
	}

	void Start () 
	{
		Leader = GameObject.FindGameObjectWithTag("Player").transform;
	}
	

	void Update () 
	{
		transform.LookAt(Leader);
		AI();
	}

	void AI()
	{
		GetComponent<NavMeshAgent>().destination = Leader.position;
	}

	/*void AIDie()
	{
		Destroy(gameObject);
	}*/
}
