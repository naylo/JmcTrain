using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour 
{
	public static InputManager instance;

	public delegate void button(int value);

	public event button onButtonNeutral;
	public event button onButtonDirect;
	public event button onButtonPersonalResponsibility;
	public event button onButtonNurturing;
	public event button onButtonDistracting;
	public event button onButtonDamaging;

	void Awake()
	{
		instance = this;
	}

	// Use this for initialization
	void Start () 
	{

	}

	public void ButtonNeutral()
	{
		if(onButtonNeutral != null)
		{
			onButtonNeutral(1);
		}
	}
	public void ButtonDirect()
	{
		if(onButtonDirect != null)
		{
			onButtonDirect(1);
		}
	}

	public void ButtonPersonalResponsibility()
	{
		if(onButtonPersonalResponsibility != null)
		{
			onButtonPersonalResponsibility(1);
		}
	}

	public void ButtonNurturing()
	{
		if(onButtonNurturing != null)
		{
			onButtonNurturing(1);
		}
	}

	public void ButtonDistracting()
	{
		if(onButtonDistracting != null)
		{
			onButtonDistracting(1);
		}
	}

	public void ButtonDamaging()
	{
		if(onButtonDamaging != null)
		{
			onButtonDamaging(1);
		}
	}
	
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
