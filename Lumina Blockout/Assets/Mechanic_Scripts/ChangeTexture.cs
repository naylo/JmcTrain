using UnityEngine;
using System.Collections;

public class ChangeTexture : MonoBehaviour 
{
	public Texture[] myTextures = new Texture[2];
	public int currentTexture;

	
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			currentTexture++;
			currentTexture %= myTextures.Length;
			GetComponent<Renderer>().material.mainTexture = myTextures[currentTexture];
		}
	}
}
