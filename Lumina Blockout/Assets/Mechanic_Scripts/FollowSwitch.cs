using UnityEngine;
using System.Collections;

public class FollowSwitch : MonoBehaviour 
{

	public SisterFollow sisFollow;
	
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.X))
		{
			sisFollow.enabled = !sisFollow.enabled;
		}
	}
}
