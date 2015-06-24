using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ActivateDialogue : MonoBehaviour 
{
	public GameObject panel;
	public GameObject pressC;
	public GameObject questionText;
	public string mainQuestion;
	public string[] answer;

	// Use this for initialization
	void OnTriggerStay ()
	{
		pressC.SetActive (true);

		if (Input.GetKeyDown(KeyCode.C)) 
		{
			ActivateText();
		}
	}

	void OnTriggerExit ()
	{
		pressC.SetActive (false);
	}

	void ActivateText ()
	{
		panel.SetActive(true);
		questionText.SetActive(true);
		//Destroy (pressC);

		for (int i = 0; i < answer.Length; i++) 
		{
			TextManager.instance.answersButtons[i].SetActive(true);
			TextManager.instance.answersTexts[i].text = answer[i];
		}

	}

	public void ButtonPress()
	{
		panel.SetActive(false);
		questionText.SetActive(false);

		for (int i = 0; i < answer.Length; i++) 
		{
			TextManager.instance.answersButtons[i].SetActive(false);
			TextManager.instance.answersTexts[i].text = answer[i];
		}

	}
}
