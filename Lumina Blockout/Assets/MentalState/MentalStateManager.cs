using UnityEngine;
using System.Collections;

public class MentalStateManager : MonoBehaviour 
{
	public static MentalStateManager instance;


	public int neutral = 0;
	public int direct = 0;
	public int personalResponsibility = 0;
	public int nurturing = 0;
	public int distracting = 0;
	public int damaging = 0;

	private string[] msmNames = new string[6];


	void Awake()
	{

		instance = this;

		msmNames [0] = "neutral";
		msmNames [1] = "direct";
		msmNames [2] = "personalResponsibility";
		msmNames [3] = "nurturing";
		msmNames [4] = "distracting";
		msmNames [5] = "damaging";
	}

	public void MentalStateCollectNeutral(int value)
	{
		//Debug.Log ("Mental State Neutral changed");
		neutral += value;

	}

	public void MentalStateCollectDirect(int value)
	{
		//Debug.Log ("Mental State Direct changed");
		direct += value;
		
	}

	public void MentalStateCollectPersonalResponsibility(int value)
	{
		//Debug.Log ("Mental State Personal Responsibility changed");
		personalResponsibility += value;
		
	}

	public void MentalStateCollectNurturing (int value)
	{
		//Debug.Log ("Mental State Nurturing changed");
		nurturing += value;
		
	}

	public void MentalStateCollectDistracting (int value)
	{
		//Debug.Log ("Mental State Distracting changed");
		distracting += value;
		
	}

	public void MentalStateCollectDamaging (int value)
	{
		//Debug.Log ("Mental State Damaging changed");
		damaging += value;
		
	}

	public void MentalStateTotal ()
	{
		int[] stateArray = new int[6];

		stateArray [0] = neutral;
		stateArray [1] = direct;
		stateArray [2] = personalResponsibility;
		stateArray [3] = nurturing;
		stateArray [4] = distracting;
		stateArray [5] = damaging;

		int highestState = 0;
		int ending = 0;

		for (int i = 0; i < stateArray.Length; i++) 
		{
			if(stateArray[i] > highestState)
			{
				highestState = stateArray[i];
				ending = i;
			}
		}

		Debug.Log (msmNames[ending]);
		Application.LoadLevel (msmNames[ending]);

	}

	public void MentalStateSave()
	{
		PlayerPrefs.SetInt("Neutral", neutral);

		PlayerPrefs.SetInt("Direct", direct);

		PlayerPrefs.SetInt("Personal Responsibility", personalResponsibility);
	}

	public void MentalStateLoad()
	{
		neutral = PlayerPrefs.GetInt("Neutral");

		direct = PlayerPrefs.GetInt("Direct");

		personalResponsibility = PlayerPrefs.GetInt("Personal Responsibility");
	}

	/*public void BeachScene ()
	{
		PlayerPrefs.DeleteAll();
	}*/
}
