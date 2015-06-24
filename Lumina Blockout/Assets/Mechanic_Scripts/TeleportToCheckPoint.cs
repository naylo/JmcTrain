using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TeleportToCheckPoint : MonoBehaviour 
{
	public static TeleportToCheckPoint instance;

	public GameObject player;
	public GameObject sister;
	public GameObject checkpoint;
	public bool isfound;
	public float fadeSpeed = 1.5f;
	public Image fader;
	public GameObject canvas;

	public Animator anim;

	void Awake()
	{
		instance = this;

		isfound = false;
	}



	void Update()
	{
		if(isfound == true)
		{
			if( Input.GetKey(KeyCode.E))
			{
				anim.SetTrigger("PlayFader");
				StartCoroutine(Teleportation());
			}

		}
	}

	IEnumerator Teleportation()
	{
		if( Input.GetKey(KeyCode.E))
		{
			yield return new WaitForSeconds (1.7f);
			player.transform.position = checkpoint.transform.position;
			sister.transform.position = checkpoint.transform.position;
		}
		
	}
}


