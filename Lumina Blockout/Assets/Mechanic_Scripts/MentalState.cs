using UnityEngine;
using System.Collections;

public class MentalState : MonoBehaviour 
{

	public static MentalState instance;

	public float mentalState = 100;
	public float maxMentalState = 100;
	public float regenerateSpeed = 1;
	public float damageAmount = 1;




	// Use this for initialization
	void Awake ()
	{
		instance = this;
	}

	void Start () 
	{
		mentalState = maxMentalState;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(mentalState < maxMentalState && mentalState > 0)
		{
			UpdateMentalState(regenerateSpeed * Time.deltaTime);

			if(mentalState > maxMentalState)
			{
				mentalState = maxMentalState;
			}

			LightAndTexture.instance.LightIntensity(mentalState);
		}

		/*if(Input.GetKey(KeyCode.P))
		{
			mentalState -= damageAmount;
		}*/
	}

	public void UpdateMentalState(float damage)
	{
		if(mentalState > 0)
		{
			mentalState += damage;
		}

	}

}
