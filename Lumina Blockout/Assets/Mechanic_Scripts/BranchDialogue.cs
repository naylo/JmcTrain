using UnityEngine;
using System.Collections;

[System.Serializable]
public class BranchDialogue : MonoBehaviour 
{
	public string answerToPreviousQuestion;
	public string[] dialogue;
	public string question;
	public BranchDialogue[] answers;
}
