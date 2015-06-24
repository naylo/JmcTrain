using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using System.Collections.Generic;

public class BlueDialogue : MonoBehaviour 
{
	public static BlueDialogue instance;

	public string[] myDialogue;
	public string[] myAnswers;

	public int currentText;
	
	public Text myTextObject;

	public PlayerControl playerCtrl;

	public GameObject bluePanel;
	public GameObject trigger;


	void Awake()
	{
		instance = this;
	}

	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			SwitchText();
		}
	}

	public void SwitchText()
	{
		myTextObject.text = myDialogue[currentText];
		print(currentText);
		if ((currentText + 1) == myDialogue.Length) 
		{
			myTextObject.gameObject.SetActive (false);
			bluePanel.gameObject.SetActive (false);
			playerCtrl.enabled = !playerCtrl.enabled;
			Destroy (trigger);
		} 
		else 
		{
			currentText++;
		}
	}
}
