using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class KaiLeeDialogue : MonoBehaviour {

	public BranchDialogue myText;

	public Button[] myAnswerButtons;

	//public string[] conversation;
	public PlayerControl playerCtrl;
	public GameObject bluePanel;

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {

			//THe UI Text box
			BlueDialogue.instance.myTextObject.gameObject.SetActive(true);

			//Our dialogue branches
			BlueDialogue.instance.myDialogue = myText.dialogue;

			BlueDialogue.instance.currentText = 0;

			//DIsable player control
			playerCtrl.enabled = !playerCtrl.enabled;

			//ACtivate the panel
			bluePanel.gameObject.SetActive (true);

			//Assign Values for text.
			BlueDialogue.instance.myTextObject.text = myText.question;
			
			int num = 0;

			//Assign values for answers
			foreach(BranchDialogue br in myText.answers)
			{
				myAnswerButtons[num].gameObject.SetActive(true);
				myAnswerButtons[num].GetComponentInChildren<Text>().text = br.answerToPreviousQuestion;

				num ++;
			}
		}
	}

	public void UpdateMyText(int answerNum)
	{
		//Turn off buttons/answers
		foreach(Button b in myAnswerButtons)
		{
			b.gameObject.SetActive(false);
		}

		//Assign our new branch.
		myText = myText.answers[answerNum];

		BlueDialogue.instance.myTextObject.text = myText.question;

		//Refill text for answers
		int num = 0;
		if(myText.answers.Length >0)
		{
			foreach(BranchDialogue br in myText.answers)
			{
				myAnswerButtons[num].gameObject.SetActive(true);
				myAnswerButtons[num].GetComponentInChildren<Text>().text = br.answerToPreviousQuestion;

				num ++;
			}
		}
		else
		{
			//Insert fade and give back control here.

			StartCoroutine(EndDialogue());

		}
	}

	IEnumerator EndDialogue()
	{

			yield return new WaitForSeconds (4);
			playerCtrl.enabled = !playerCtrl.enabled;
			BlueDialogue.instance.myTextObject.gameObject.SetActive(false);
			bluePanel.gameObject.SetActive (false);

	}
}
