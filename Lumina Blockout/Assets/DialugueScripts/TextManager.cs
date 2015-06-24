using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextManager : MonoBehaviour 
{
	public static TextManager instance;

	public Text question;
	public Text[] answersTexts;
	public GameObject[] answersButtons;

	// Use this for initialization
	void Awake () 
	{
		instance = this;
	}

}
