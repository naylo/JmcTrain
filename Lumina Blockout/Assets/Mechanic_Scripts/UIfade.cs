using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIfade : MonoBehaviour 
{
	public Text ourText;
	public float fadeSpeed = 5f;
	public bool entrance;
	public GameObject ourCanvas;

	void Awake ()
	{
		ourText = ourCanvas.GetComponentInChildren<Text> ();
		ourText.color = Color.clear;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		ColourChange ();
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Player") 
		{
			entrance = true;
		}
	}

	void OnTriggerExit (Collider other)
	{
		if (other.gameObject.tag == "Player") 
		{
			entrance = false;
		}
	}

	void ColourChange ()
	{
		if(entrance)
		{
			ourText.color = Color.Lerp(ourText.color, Color.white, fadeSpeed * Time.deltaTime);
		}

		if(!entrance)
		{
			ourText.color = Color.Lerp(ourText.color, Color.clear, fadeSpeed * Time.deltaTime);
		}
	}
}
