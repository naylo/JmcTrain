using UnityEngine;
using System.Collections;

public class LightAndTexture : MonoBehaviour 
{
	public static LightAndTexture instance;

	private Light myLight;
	public Texture[] myTextures = new Texture[2];
	public int currentTexture;

	public float highIntensity = 1.3f;
	public float lowIntensity = 0f;



	void Awake()
	{
		instance = this;
	}


	void Start () 
	{
		myLight = GetComponent<Light>();
	}
	

	void Update () 
	{
		if(Input.GetKeyUp(KeyCode.LeftControl))
		{
			myLight.enabled = !myLight.enabled;
		}



		if (Input.GetKeyDown(KeyCode.LeftControl))
		{
			currentTexture++;
			currentTexture %= myTextures.Length;
			GetComponent<Renderer>().material.mainTexture = myTextures[currentTexture];
		}

	}

	public void LightIntensity(float intensity)
	{
		float intensityPercentage = (intensity *highIntensity) / 100;
		myLight.intensity = intensityPercentage;
		//Debug.Log(intensityPercentage);
	}
}
